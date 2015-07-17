using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MASTERPLAN.Startup))]
namespace MASTERPLAN
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
