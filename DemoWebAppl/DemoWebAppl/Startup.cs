using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebAppl.Startup))]
namespace DemoWebAppl
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
