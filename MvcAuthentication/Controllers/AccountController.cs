using MvcAuthentication.BLL;
using MvcAuthentication.Common;
using MvcAuthentication.DAL;
using MvcAuthentication.Interfaces;
using MvcAuthentication.Models;
using MvcAuthentication.Security;
using MvcAuthentication.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcAuthentication.Controllers
{
  
    public class AccountController : Controller
    {

        public AccountController()
        {
       
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 服务器接收数据
        /// </summary>
        /// <returns></returns>
        
        [HttpPost]
        [AllowAnonymous]
        public ActionResult BeforeLogin()
        {

            string APPKEY = Guid.NewGuid().ToString();
            string APPSECRET = Guid.NewGuid().ToString();


            var ss = new AccountContext();
         var bm=   ss.BussinessManagers.FirstOrDefault(m => m.APPKEY == APPKEY&m.APPSECRET == APPSECRET);
         if (bm == null)
             return Content("业务系统没注册");
     
            else
             return base.Redirect("~/account/login");

         //return base.Redirect("~/ControllerDemo/ContentResult");
           
        }

        public ActionResult Error()
        {
            return Content("业务系统没注册");
        
        }
        //
        // POST: /Account/Login
        [HttpPost]
        [MvcAuthentication.Startup.CustomAuthorizeAttri(Roles = "3.2")]
        public ActionResult Login(LoginViewModel model)
        {
          
            MyPrincipal principal = new MyPrincipal(model.Email);
            if (!principal.Identity.IsAuthenticated)
            {
               
            }
            else
            {
                FormsAuthentication.SetAuthCookie(model.Email, false, FormsAuthentication.FormsCookiePath);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(model.Email, false, 5);

                FormsIdentity identy = new FormsIdentity(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                Response.Cookies.Add(cookie);
                //User.Identity.
                System.Web.HttpContext.Current.User = principal;
          
                // 如果用户通过验证,则将用户信息保存在缓存中,以备后用 
                // 在实际中,朋友们可以尝试使用用户验证票的方式来保存用户信息,这也是.NET内置的用户处理机制 
               // HttpContext.GetOwinContext().Authentication.
               // var Muser = User as principal;
              //  User = principal;
                Hashtable userMessage = new Hashtable();
                userMessage.Add("UserID", model.Email);
                userMessage.Add("UserPassword", model.Email);
                //Cache CA = new Cache();
                //CA.Insert("UserMessage", userMessage);

                System.Web.HttpContext.Current.Cache.Insert("UserMessage", userMessage);
                
            //  Cache.Insert("UserMessage", userMessage); 
                
              
            } 
           // HttpContext.GetOwinContext().Authentication.User.Identity.IsAuthenticated
           // User.Identity.u
            UserB.InsertUser(new User { Name = "shens" });
          
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
           
        }

        //

        //
        // POST: /Account/VerifyCode
        [MvcAuthentication.Startup.CustomAuthorizeAttri(Roles="3.2")]
        public ActionResult XuLogin()
        {
            return View();
        }

        //
        // GET: /Account/Register
        [Authorize()]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
       // [ValidateAntiForgeryToken]
        public  ActionResult Register(RegisterViewModel model)
        {
           AccountContext acContext=new DAL.AccountContext();
            if (ModelState.IsValid)
            {
               // var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
               // var result = await UserManager.CreateAsync(user, model.Password);
                //if (result.Succeeded)
                //{
                //   // await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                acContext.Users.Add(new DAL.User { Email = model.Email, Password = model.Password });
                acContext.SaveChanges();
                  
                    return RedirectToAction("Index", "Home");
               // }
           
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(model);
        }


        //
        // GET: /Account/Login
       [MvcAuthentication.Startup.NoNeedLogin]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

    }
}