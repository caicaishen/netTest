using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserMvc_Proj.Startup))]
namespace UserMvc_Proj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
