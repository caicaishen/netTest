using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_Proj.Controllers
{
    public class HomeController : Controller
    {

        [Authorize(Roles = "Users")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Managers")]
        public ActionResult Manager()
        {
            return View();
        }
    }
}