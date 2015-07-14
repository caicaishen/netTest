using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using Thinktecture.IdentityServer.Core.Models;

namespace MvcNoAuthentication
{
    public static class Scopes
    {

        public static IEnumerable<Scope> Get()
        {
            var scopes = new List<Scope>
        {
            new Scope
            {
                Enabled = true,
                Name = "roles",
                Type = ScopeType.Identity,
                Claims = new List<ScopeClaim>
                {
                    new ScopeClaim("role")
                }
            },
              new Scope
            {
                Enabled = true,
                Name = "sampleApi",
                Description = "Access to a sample API",
                 Claims = new List<ScopeClaim>
                {
                    new ScopeClaim("role")
                },
                Type = ScopeType.Resource
            }
        };

            scopes.AddRange(StandardScopes.All);

            return scopes;
        }
    }
}