using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcAuthentication.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext()
            : base("AccountConnection")
        {
          
            
        
        }
        static AccountContext()
        {
            Database.SetInitializer< AccountContext>(null);

            //Database.SetInitializer(
            //          new DropCreateDatabaseAlways<AccountContext>());
            //using (var context = new AccountContext())
            //{
            //    context.Database.Initialize(true);
            //}
        }
        public DbSet<User> Users {get;set;}
    
          public DbSet<BussinessManager> BussinessManagers { get; set; }
        
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          //  modelBuilder.Entity<User>().HasRequired(p => p.City).WithMany(l => l.Users).HasForeignKey(p => p.TargetCityID);
           // modelBuilder.Entity<User>().Property(item => item.Count).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           // modelBuilder.Entity<User>().Property(item => item.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           // modelBuilder.Entity<User>().ToTable("ac_User");
           // modelBuilder.Configurations.Add(new User());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    
}