using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace MvcNoAuthentication
{
    public static class Users
    {
        public static string navar="";
        public static string pwdvar = "";
        public static List<InMemoryUser> Get()
        {
            
            return new List<InMemoryUser>
        {
            new InMemoryUser
            {
                Username = "bob5",
                Password = "secret5",
                Subject = "1",
                
                Claims = new[]
                {
                    new Claim(Constants.ClaimTypes.GivenName, "Bob"),
                    new Claim(Constants.ClaimTypes.FamilyName, "Smith"),
                    new Claim(Constants.ClaimTypes.Role, "Geek"),
                    new Claim(Constants.ClaimTypes.Role, "Foo")
                }
            }
        };
        }

    }
}