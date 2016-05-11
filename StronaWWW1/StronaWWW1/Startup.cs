using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StronaWWW1.Startup))]
namespace StronaWWW1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
