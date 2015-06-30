using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_Proj.Startup))]
namespace web_Proj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
