using MvcAuthentication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAuthentication.Interfaces
{
    interface IUser
    {
        List<User> SelectUser();
        List<User> SelectUser(string email);

        void InsertUser(User user);
    }
}
