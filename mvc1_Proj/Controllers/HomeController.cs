using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mvc1_Proj.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       // [Authorize(Roles="Users")]
        public ActionResult Index()
        {
            string userna = "shenman";
            string passw = "sdfd";
            FormsAuthentication.SetAuthCookie(userna, false);
         //   HttpContext.User.Identity.Name = userna;
         
            return View();
        }

       // [Authorize(Roles = "Users")]
        public ActionResult Manager()
        {
         
            var ss = HttpContext.User.Identity.IsAuthenticated;
           if (HttpContext.User.Identity.IsAuthenticated)
                ViewBag.succ = true;
            else
                ViewBag.succ = false;
            return View();
        }

       
    }
}