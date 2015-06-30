using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc3_Proj.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public UserManager
        // 初始化 UserManager
        public AccountController()
            : this()
        {
            new UserManager<IdentityUser>(new UserStore(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/user.txt")));
        }
        public bool Login(IdentityUser model)
        {
            // 检查用用户名密码是否正确
            var user = await UserManager.FindAsync(model.UserName, model.Password);
            if (user != null)
            {
                // Forms 登录代码
            }

        }

        // 注册用户
        public void Regesiter(IdentityUser model)
        {
            var user = new IdentityUser() { UserName = model.UserName };
            var result = await UserManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // 创建用户成功
            }
        }
    }
}

    
