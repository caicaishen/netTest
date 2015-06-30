using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Models;

namespace identityHost
{
    static class Scopes
    {
        public static List<Scope> Get()
        {
            return new List<Scope> { new Scope { Name = "api1" } };
        }

    }
}
