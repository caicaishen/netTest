//using System.Data.Entity;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using System;
//using System.Data.Entity.ModelConfiguration;

using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Security.Claims;

namespace UserMvc_Proj.Models
{
    // 可以通过向 ApplicationUser 类添加更多属性来为用户添加配置文件数据。若要了解详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=317594。
    public class ApplicationUser : IdentityUser
    {
        // IdentityRole
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // 请注意，authenticationType 必须与 CookieAuthenticationOptions.AuthenticationType 中定义的相应项匹配
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // 在此处添加自定义用户声明
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
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

        //    // Keep this:
        //    modelBuilder.Entity<IdentityUser>().ToTable("AspNetUsers");

        //    // Change TUser to ApplicationUser everywhere else - 
        //    // IdentityUser and ApplicationUser essentially 'share' the AspNetUsers Table in the database:
        //    EntityTypeConfiguration<ApplicationUser> table =
        //        modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers");

        //    table.Property((ApplicationUser u) => u.UserName).IsRequired();

        //    // EF won't let us swap out IdentityUserRole for ApplicationUserRole here:
        //    modelBuilder.Entity<ApplicationUser>().HasMany<IdentityUserRole>((ApplicationUser u) => u.Roles);
        //    modelBuilder.Entity<IdentityUserRole>().HasKey((IdentityUserRole r) =>
        //        new { UserId = r.UserId, RoleId = r.RoleId }).ToTable("AspNetUserRoles");

        //    // Leave this alone:
        //    EntityTypeConfiguration<IdentityUserLogin> entityTypeConfiguration =
        //        modelBuilder.Entity<IdentityUserLogin>().HasKey((IdentityUserLogin l) =>
        //            new
        //            {
        //                UserId = l.UserId,
        //                LoginProvider = l.LoginProvider,
        //                ProviderKey
        //                    = l.ProviderKey
        //            }).ToTable("AspNetUserLogins");

        ////    entityTypeConfiguration.HasRequired<IdentityUser>((IdentityUserLogin u) => u.User);
        //    EntityTypeConfiguration<IdentityUserClaim> table1 =
        //        modelBuilder.Entity<IdentityUserClaim>().ToTable("AspNetUserClaims");

        // //   table1.HasRequired<IdentityUser>((IdentityUserClaim u) => u.User);
           
        //    // Add this, so that IdentityRole can share a table with ApplicationRole:
        //    modelBuilder.Entity<IdentityRole>().ToTable("AspNetRoles");

        //    // Change these from IdentityRole to ApplicationRole:
        //    //EntityTypeConfiguration<ApplicationRole> entityTypeConfiguration1 =
        //      //  modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles");

        //    modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles");
        //    //entityTypeConfiguration1.Property((ApplicationRole r) => r.Name).IsRequired();
        }
    }
}