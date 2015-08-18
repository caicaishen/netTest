using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using UserMvc_Proj.Models;
using UserMvc_Proj.Controllers;
using Microsoft.Practices.Unity;
using UserMvc_Proj.Interfaces;

namespace UserMvc_Proj.bussiness.Test
{
    [TestFixture]
    public class UsersTest
    {

        [Test]
        public void IOrderTest() {
            IUnityContainer container = new UnityContainer()
            .RegisterType<ILogger, ConsoleLogger>()
            .RegisterType<IOrder, CommonOrder>(new ContainerControlledLifetimeManager())
            .RegisterType<IOrderWithLogging, MethodCallInjection>();
            //.RegisterType<IOrderWithLogging, PropertyInjection>();

            IOrder order = container.Resolve<IOrder>();
            order.Discount = 0.77;

            IOrderWithLogging o = container.Resolve<IOrderWithLogging>();

            string dd = o.Output();

            Console.Out.WriteLine(dd);
            //.RegisterType<ILogger, ConsoleLogger>()
            //.RegisterType<IOrder, CommonOrder>(new ContainerControlledLifetimeManager())
            //.RegisterType<IOrderWithLogging, SingleConstructor>();


            //IOrder order = container.Resolve<IOrder>();
            //order.Discount = 0.8;

            //IOrderWithLogging o = container.Resolve<IOrderWithLogging>();

            //string dd = o.Output();
            //Console.Out.WriteLine(dd);


            //container.RegisterType<IOrder, CommonOrder>(new ContainerControlledLifetimeManager());

            //IOrder order = container.Resolve<IOrder>();
            //order.Discount = 0.8;


            //IOrder order2 = container.Resolve<IOrder>();
            //string dd = order2.DumpDiscount();

            //Console.Out.WriteLine(dd);


            

            var result = true;
            Assert.IsTrue(result); 
        
        }

        [Test]
        public void MyFirstTest(){

           // AccountController cotro = new AccountController();


      // var dsd=     cotro.Login("");
           
//            List<string> ff = new List<string>();
//            string strconn = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=C:\Users\sweetyuser\Documents\GitHub\UserMvc_Proj\App_Data\aspnet-UserMvc_Proj-20150630040702.mdf;Initial Catalog=aspnet-UserMvc_Proj-20150630040702;Integrated Security=True";
//            using ( SqlConnection con = new SqlConnection(strconn))
//            {
//                con.Open();

//                string cmdstr = "select * from AspNetUsers";
//                SqlCommand com = new SqlCommand(cmdstr, con);//使用指定的SQL命令和连接对象创建SqlCommand对象
//                SqlDataReader dr = com.ExecuteReader();

//                while(dr.Read())
              
//{
//    ff.Add(dr[1].ToString());
//}
//dr.Close();

//            }



           Users curUser = new Users();
           var dd = curUser.GetALL2();
            Console.Out.WriteLine("sdfsdf");
          //return;
//new Mock

            
            var result = true;
            Assert.IsTrue(result); 
        }


  [TestFixtureSetUp]
        // [SetUp]
 public void TestInitialize()
 {
    // Users curUser = new Users();
    // var dd = curUser.GetALL();

     List<string> ff = new List<string>();
     string strconn = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=C:\Users\sweetyuser\Documents\GitHub\UserMvc_Proj\App_Data\aspnet-UserMvc_Proj-20150630040702.mdf;Initial Catalog=aspnet-UserMvc_Proj-20150630040702;Integrated Security=True";
     using (SqlConnection con = new SqlConnection(strconn))
     {
         con.Open();

         string cmdstr = "select * from AspNetUsers";
         SqlCommand com = new SqlCommand(cmdstr, con);//使用指定的SQL命令和连接对象创建SqlCommand对象
         SqlDataReader dr = com.ExecuteReader();

         while (dr.Read())
         {
             ff.Add(dr[1].ToString());
         }
         dr.Close();
         con.Close();
     }


         
         }
        [Test]
        public void sdd()
        {

            Mock<IUSD_RMB_ExchangeRateFeed> mockObject = new Mock<IUSD_RMB_ExchangeRateFeed>();
            mockObject.Setup(m => m.GetActualUSDValue()).Returns(500);
            IUSD_RMB_ExchangeRateFeed value = mockObject.Object;
            var result = true;
            Assert.IsTrue(result);


        }



        // 定义mock的逻辑
        private IUSD_RMB_ExchangeRateFeed prvGetMockExchangeRateFeed()
        {
            Mock<IUSD_RMB_ExchangeRateFeed> mockObject = new Mock<IUSD_RMB_ExchangeRateFeed>();
            mockObject.Setup(m => m.GetActualUSDValue()).Returns(5000);
            return mockObject.Object;
        }
        // 测试divide方法
        [Test(Description = "Divide 9 by 3. Expected result is 3.")]
        public void TC1_Divide9By3()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 3);
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test(Description = "Divide any number by zero. Should throw an System.DivideByZeroException exception.")]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TC2_DivideByZero()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 0);
        }
        [Test(Description = "Convert 1 USD to RMB. Expected result is 500.")]
        public void TC3_ConvertUSDtoRMBTest()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.ConvertUSDtoRMB(1);
            int expectedResult = 500;
            Assert.AreEqual(expectedResult, actualResult);
        }
        //[Test]
        //public void sdfs()
        //{

        //    //  Users curUser = new Users();
        //    //var dd=  curUser.GetALL();

        //    //return;
        //    //  throw new Exception("testssdfd");
        //    var result = true;
        //    Assert.IsTrue(result);


        //}

        //[Test]
        //public void ddds()
        //{

        //    //  Users curUser = new Users();
        //    //var dd=  curUser.GetALL();

        //    //return;
        //    //  throw new Exception("testssdfd");
        //    var result = false;
        //    Assert.IsTrue(result);


        //}
       
    }
}