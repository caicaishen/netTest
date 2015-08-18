using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserMvc_Proj.Models;

namespace UserMvc_Proj.bussiness
{
    public class Users
    {
      static   ApplicationDbContext2 dbcon;
         static Users() {

            dbcon = new ApplicationDbContext2();
        }

        public List<ApplicationUser> GetALL()
        {
            var sd = dbcon.Users;
            var allUsers =sd.ToList();
            return allUsers;
        
        }

        public List<ApplicationUser> GetALL2()
        {
            List<ApplicationUser> userss = new List<ApplicationUser> { new ApplicationUser { UserName = "sdf", Email = "sdf@qq.com" }, new ApplicationUser { UserName = "sdfs", Email = "dsdf@qq.com" } };
            return userss;

        }
    }


    public class ApplicationDbContext2 : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext2()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }



        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles");
        }
    }
}