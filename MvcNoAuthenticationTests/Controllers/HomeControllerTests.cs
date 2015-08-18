using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcNoAuthentication.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MvcNoAuthentication.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {

        }

        [TestMethod()]
        public void ToIntTest()
        {
            HomeController target = new HomeController();
            string value = "5";
            int expected = 5;//预期的值
            int actual;//实际的值
            actual = target.ToInt(value);
            Assert.AreEqual(expected, actual);
            value = "5.5";
            expected = 5;
            actual = target.ToInt(value);
            Assert.AreEqual(expected, actual);
        }
    }
}
