using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPPCRental.Startup))]
namespace WebPPCRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
