using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.WebPages;

namespace WebPPC.UITests.Selenium.Config
{
    public class IisExpressWebServer
    {
        private static WebApplication _application;
        private static Process _webHostProcess;

        public IisExpressWebServer(WebApplication application)
        {
            if (application == null)
                throw new ArgumentNullException("The web application must be set.");
            _application = application;
        }

        public void Start(string configTransform = null)
        {
            ProcessStartInfo webHostStartInfo;

            if (configTransform == null)
            {
                webHostStartInfo = InitializeIisExpress(_application);
            }
            else
            {
                var siteDeployer = new MsBuildDeployer(_application.Location);
                var deployPath = Path.Combine(Environment.CurrentDirectory, "TestSite2");
                webHostStartInfo = InitializeIisExpress(_application, deployPath);
            }

            _webHostProcess = new Process();
            var key = Environment.Is64BitOperatingSystem ? "programfiles(x86)" : "programfiles";
            var programfiles = Environment.GetEnvironmentVariable(key);

            _webHostProcess.StartInfo.FileName = string.Format("{0}\\IIS Express\\iisexpress.exe", programfiles);
            _webHostProcess.StartInfo.Arguments = string.Format("/path:{0} /port:{1}", _application.Location.FullPath, _application.PortNumber);

            _webHostProcess.Start();

            //_webHostProcess = Process.Start(webHostStartInfo);
            //_webHostProcess.TieLifecycleToParentProcess();
        }

        public void Stop()
        {
            if (_webHostProcess == null)
                return;
            if (!_webHostProcess.HasExited)
                _webHostProcess.Kill();
            _webHostProcess.Dispose();
        }

        private static ProcessStartInfo InitializeIisExpress(WebApplication application, string deployPath = null)
        {
            // todo: grab stdout and/or stderr for logging purposes?
            var key = Environment.Is64BitOperatingSystem ? "programfiles(x86)" : "programfiles";
            var programfiles = Environment.GetEnvironmentVariable(key);

            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Normal,
                ErrorDialog = true,
                LoadUserProfile = true,
                CreateNoWindow = false,
                UseShellExecute = false,
                Arguments = String.Format("/path:{0} /port:{1}", deployPath ?? application.Location.FullPath, application.PortNumber),
                FileName = string.Format("{0}\\IIS Express\\iisexpress.exe", programfiles)
            };
            //var startInfo = new ProcessStartInfo(string.Format("{0}\\IIS Express\\iisexpress.exe", programfiles), string.Format("/path:{0} /port:{1}", deployPath ?? application.Location.FullPath, application.PortNumber));

            foreach (var variable in application.EnvironmentVariables)
                startInfo.EnvironmentVariables.Add(variable.Key, variable.Value);

            return startInfo;
        }
    }
}
