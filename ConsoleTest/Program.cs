using MvcNoAuthentication.Tests.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        #region 测试单元测试
        static void Main(string[] args)
        {

            new HomeControllerTest().Index();
            Console.WriteLine("success");
            Console.ReadLine();
        } 
        #endregion
    }
}
