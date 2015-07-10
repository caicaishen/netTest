using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAuthentication.Startup))]
namespace MvcAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
