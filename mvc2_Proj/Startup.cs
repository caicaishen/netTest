using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc2_Proj.Startup))]
namespace mvc2_Proj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
