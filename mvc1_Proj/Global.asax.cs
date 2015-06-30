using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc1_Proj
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_AuthenticateRequest() {
            //var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Name, "Jesse Liu"));
            //claims.Add(new Claim(ClaimTypes.Role, "Users"));
           
            //var identity = new ClaimsIdentity(claims, "MyClaimsLogin");


            //ClaimsPrincipal pricipal = new ClaimsPrincipal(identity);
            //HttpContext.Current.User = pricipal;
        }

        
    }
}
