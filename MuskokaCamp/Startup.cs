using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuskokaCamp.Startup))]
namespace MuskokaCamp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
