using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Thinktecture.IdentityModel.Client;

namespace MvcNoAuthentication.Controllers
{
    public class CallApiController : Controller
    {
        public async Task<ActionResult> UserCredentials()
        {
            var user = User as ClaimsPrincipal;
            var token = user.FindFirst("access_token").Value;
            var result = await CallApi(token);

            ViewBag.Json = result;
            return View("ShowApiResult");
        }

        public async Task<ActionResult> ClientCredentials()
        {
            var response = await GetTokenAsync();
            var result = await CallApi(response.AccessToken);

            ViewBag.Json = result;
         //   return View("ShowApiResult");

            return View();
        }
        // GET: CallApi
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private async Task<TokenResponse> GetTokenAsync()
        {
            var client = new OAuth2Client(
                new Uri("https://localhost:44301/identity2/connect/token"),
                "mvc_service",
                "secret");

            return await client.RequestClientCredentialsAsync("sampleApi");
        }

        private async Task<string> CallApi(string token)
        {
            var client = new HttpClient();
            client.SetBearerToken(token);
            try
            {
                var json = await client.GetStringAsync("https://localhost:44302/identity");
                return JArray.Parse(json).ToString();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            
        }
    }
}