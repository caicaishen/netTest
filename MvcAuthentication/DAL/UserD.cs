using MvcAuthentication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAuthentication.DAL
{
    public class UserD : IUser
    {
       public AccountContext acContext;
        
        public UserD() {

            acContext = new AccountContext();
        }
        public List<User> SelectUser(string email)
        {
            return null;
        }

        public List<User> SelectUser()
        {
            return null;
        }


        public void InsertUser(User user)
        {
            acContext.Users.Add(user);
            acContext.SaveChanges();
        }
    }
}