﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thinktecture.IdentityServer.Core.Models;

namespace MvcNoAuthentication
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
        {
            new Client 
            {
                Enabled = true,
                ClientName = "MVC Client",
                ClientId = "mvc",
                Flow = Flows.Implicit,

                RedirectUris = new List<string>
                {
                    "http://localhost:44300/home/about"
                },

                PostLogoutRedirectUris = new List<string>
               {
                    "http://localhost:44300/home/index"
               }
            },
               new Client
            {
                Enabled = true,
                ClientName = "MVC Client (service communication)",
                ClientId = "mvc_service",
                ClientSecrets = new List<ClientSecret>
                {
                    new ClientSecret("secret".Sha256())
                },

                Flow = Flows.ClientCredentials
            }
        };
        }

    }
}