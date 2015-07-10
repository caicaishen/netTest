using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcAuthentication.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        /// <summary>
        /// 创建数据库时才会执行
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(AccountContext context)
        {
            base.Seed(context);

            context.Users.Add(new User { UserID = 1, Name = "shensonly" });

            context.SaveChanges();
            //AccountContext.InitialAccountData(context);
            //AccountContext.InitialIdentityData(context);

            //if (AccountContext.OtherSeeder != null)
            //{
            //    AccountContext.OtherSeeder.InitialData(context);
            //}
        }
    }
   
}