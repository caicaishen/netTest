using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MyUnitTest.Tests
{
    [TestClass()]
    public class TestFunctionTests
    {
        [TestMethod()]
        public void ToIntTest()
        {
            TestFunction target = new TestFunction();
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
