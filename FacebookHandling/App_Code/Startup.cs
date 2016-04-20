using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookHandling.Startup))]
namespace FacebookHandling
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
