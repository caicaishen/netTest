using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcAuthentication.DAL
{
    //#region 草稿测试
    //[Table("ac_User")]
    //public class User
    //{
    //    [Key]
    //    public int UserID { get; set; }


    //    public string UserName { get; set; }

    //    //     public int TargetCityID { get; set; }

    //    //   public City City { get; set; }

    //    //  public int Count { get; set; }

    //}

    ////public class City
    ////{
    ////    [Key]
    ////    public int CityID { get; set; }

    ////    public string CityName { get; set; }

    ////    public List<User> Users { get; set; }




    ////}


    //public class Person
    //{
    //    public int PersonId { get; set; }
    //    public int SocialSecurityNumber { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    [Timestamp]
    //    public byte[] RowVersion { get; set; }
    //    public PersonPhoto Photo { get; set; }
    //}

    //public class PersonPhoto
    //{
    //    [Key, ForeignKey("PhotoOf")]
    //    public int PersonId { get; set; }
    //    public byte[] Photo { get; set; }
    //    public string Caption { get; set; }
    //    public Person PhotoOf { get; set; }
    //}


    //public class Destination
    //{
    //    public int DestinationId { get; set; }
    //    public string Name { get; set; }
    //    // public string Country { get; set; }
    //    //  public string Description { get; set; }
    //    public byte[] Photo { get; set; }
    //    public List<Lodging> Lodgings { get; set; }
    //}

    //public class Lodging
    //{
    //    public int LodgingId { get; set; }
    //    public string Name { get; set; }
    //    public string Owner { get; set; }
    //    public bool IsResort { get; set; }
    //    public decimal MilesFromNearestAirport { get; set; }
    //    //外键 
    //    public int TargetDestinationId { get; set; }
    //    public Destination Target { get; set; }
    //} 
    //#endregion

    [Table("ac_BussinessManager")]
    public class BussinessManager
    {
        [Key]
        public int BussinessID { get; set; }
        [MaxLength(50)]
        public string APPKEY { get; set; }
         [MaxLength(50)]
        public string APPSECRET { get; set; }
        [MaxLength(300)]
        public string LoginRUrl { get; set; }
        [MaxLength(300)]
        public string RegisterRUrl { get; set; }
        [MaxLength(300)]
        public string HomeUrl { get; set; }
    }
    [Table("ac_User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(15)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        public bool EmailVerified { get; set; }
        [MaxLength(30)]
        public string MobilePhone { get; set; }
        public bool MphoneVerified { get; set; }
        [MaxLength(30)]
        public string FixedPhone { get; set; }
        
        public int Role { get; set; }
    }


}