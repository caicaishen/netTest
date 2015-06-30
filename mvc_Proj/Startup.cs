using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_Proj.Startup))]
namespace mvc_Proj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
