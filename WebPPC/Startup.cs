using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPPC.Startup))]
namespace WebPPC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
