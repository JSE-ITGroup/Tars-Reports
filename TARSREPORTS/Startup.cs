using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TARSREPORTS.Startup))]
namespace TARSREPORTS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
