using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
namespace WebPPC.UITests.Selenium.Config
{
    public class MsBuildDeployer
    {
        //private object location;

        //public MsBuildDeployer(object location)
        //{
        //    this.location = location;
        //}
        private readonly IProjectLocation _projectLocation;

        public MsBuildDeployer(IProjectLocation projectLocation)
        {
            _projectLocation = projectLocation;
        }

        public void Deploy(string configTransformName, string deployPath)
        {
            var loggers = new Microsoft.Build.Framework.ILogger[] { new ConsoleLogger(LoggerVerbosity.Normal) };
            var parameters = new BuildParameters { Loggers = loggers };

            var globalProperties = new Dictionary<string, string>
            {
                { "Configuration", configTransformName },
                { "_PackageTempDir", deployPath }
            };

            var requestData = new BuildRequestData(_projectLocation.ProjectName, globalProperties, null,
                new[] { "Clean", "Package" }, null);

            var result = BuildManager.DefaultBuildManager.Build(parameters, requestData);

            if (result.OverallResult != BuildResultCode.Success || !Directory.Exists(deployPath))
            {
                throw new Exception("Build failed.");
            }
        }
    }
}
