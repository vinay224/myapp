using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleproj.Startup))]
namespace sampleproj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
