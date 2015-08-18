using System;
using NUnit.Framework;
using UserMvc_Proj.bussiness;

namespace UserMvc_Proj.Test
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //    }
    //}

    [TestFixture]
    public class UsersTest
    {

        [Test]
        public void MyFirstTest()
        {
            
            Users curUser = new Users();
           // var dd = curUser.GetALL();
            var dd = curUser.GetALL2();

            //return;

            var result = true;
          Assert.IsTrue(result);
        }

    }
}
