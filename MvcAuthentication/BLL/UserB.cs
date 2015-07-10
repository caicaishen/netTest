using MvcAuthentication.DAL;
using MvcAuthentication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAuthentication.BLL
{
    public class UserB
    {
        public static void InsertUser(User user)
        {
            IUser userDAL = new UserD();//  刚刚地方
            userDAL.InsertUser(user);
        }
    }
}