using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using MvcAuthentication.Models;
using System.Web.Security;
using System.Web.Mvc;
using System.Web;
using MvcAuthentication.Security;

namespace MvcAuthentication
{
    public partial class Startup
    {
        // 有关配置身份验证的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // 配置数据库上下文、用户管理器和登录管理器，以便为每个请求使用单个实例
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // 使应用程序可以使用 Cookie 来存储已登录用户的信息
            // 并使用 Cookie 来临时存储有关使用第三方登录提供程序登录的用户的信息
            // 配置登录 Cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // 当用户登录时使应用程序可以验证安全戳。
                    // 这是一项安全功能，当你更改密码或者向帐户添加外部登录名时，将使用此功能。
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });            
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // 使应用程序可以在双重身份验证过程中验证第二因素时暂时存储用户信息。
            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));

            // 使应用程序可以记住第二登录验证因素，例如电话或电子邮件。
            // 选中此选项后，登录过程中执行的第二个验证步骤将保存到你登录时所在的设备上。
            // 此选项类似于在登录时提供的“记住我”选项。
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);

            // 取消注释以下行可允许使用第三方登录提供程序登录
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            //app.UseFacebookAuthentication(
            //   appId: "",
            //   appSecret: "");

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "",
            //    ClientSecret = ""
            //});
        }

        public class NoNeedLogin : Attribute
        {

        }


        public class CustomAuthorizeAttri : AuthorizeAttribute
        {

            /// <summary>  

            /// 权限值  

            /// </summary>  

            private int _permissionID = 0;

            /// <summary  

            /// 权限值  

            /// </summary>  

            public int PermissionID
            {

                get { return _permissionID; }

                set { _permissionID = value; }

            }

            protected override bool AuthorizeCore(HttpContextBase httpContext)
            {
                bool isSuccess = base.AuthorizeCore(httpContext);
                if (isSuccess)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
            {
                base.HandleUnauthorizedRequest(filterContext);
                if (filterContext == null)
                {
                    throw new ArgumentNullException("filterContext");
                }
                else
                {
                    filterContext.HttpContext.Response.Redirect("/login.html");
                }
            }


            /// <summary>  

            /// 在过程请求授权时调用。   

            /// </summary>  

            /// <param name="filterContext">对象包括控制器、HTTP 上下文、请求上下文、操作结果和路由数据。</param>  

            public override void OnAuthorization(AuthorizationContext filterContext)
            {
                // var s=  System.Web.Caching.Cache[];
                string sds = this.Roles;
                var cocache = filterContext.HttpContext.Cache["UserMessage"];
                bool IsA = HttpContext.Current.User.Identity.IsAuthenticated;
                if (filterContext.ActionDescriptor.ActionName.ToLower() == "login")
                { }
                else
                {

                    if (HttpContext.Current.User.Identity.IsAuthenticated)
                    {

                        //这一步很重要，要代替.NET的自身的User.  

                        // IPrincipal
                        MyPrincipal MyPrincipal = new MyPrincipal(2);

                        HttpContext.Current.User = MyPrincipal;




                        string ss = "4562";
                        //if ((!MyPrincipal.IsPermissionID(_permissionID)) && (_permissionID != 0))
                        //{

                        //    HttpContext.Current.Response.Clear();

                        //    HttpContext.Current.Response.Write("<script defer>window.alert('无权操作！');history.back();</script>");

                        //    HttpContext.Current.Response.End();

                        //    filterContext.Result = new EmptyResult();

                        //}

                    }

                    else
                    {

                        FormsAuthentication.SignOut();
                        filterContext.Result = new RedirectResult("/account/Login");
                        //HttpContext.Current.Response.Clear();

                        //HttpContext.Current.Response.Write("<script defer>window.alert('无权操作！或当前登录用户已过期！\\n请重新登录或与管理员联系！');</script>");

                        // HttpContext.Current.Response.End();

                        // HttpContext.Current.Response.Redirect("http://localhost:1407/account/register");
                        //  HttpContext.Current.Response.RedirectToRoute()


                        //var Url = new UrlHelper(filterContext.RequestContext);
                        //var url =  Url.Action("Register", "Account");
                        //filterContext.Result = new RedirectResult(url);
                        // filterContext.Result=;
                        //
                    }

                }
            }


        }
    }
}