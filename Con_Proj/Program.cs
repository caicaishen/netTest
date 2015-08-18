using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Con_Proj
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}


    #region 资源文件
    class Program
    {
        static void Main(string[] args)
        {
            System.Resources.ResourceManager rs = new System.Resources.ResourceManager("Con_Proj.Resource1", typeof(Resource1).Assembly);
            var title = rs.GetString("String2");//获取资源名为title的字符串

            Console.WriteLine(title);

            Console.ReadKey();

        }
        public void SDF()
        {

            Console.WriteLine("sdfsdf");
            Console.ReadKey();
        
        }
    } 
    #endregion
    #region 0:X2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string ss = "shenssdf";

    //        string sd = string.Format("{0:X2}", ss);


    //        Console.ReadKey();
    //    }
    //} 
    #endregion

    #region regex:数组
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //string infoAll = "934234isdif89564*&@sdfkkddlwis@sdf*&@sdf123.344.234";

    //        string infoAll = @"b6d2a2ac-b2f0-4586-94ad-7cd6dcb761c9*&@16*&@http://www.baidu.com*&@localhost";
          
    //        string pattern=@"\*&@";
    //          Regex reg = new Regex(pattern);
    //      //  Regex reg2=new Regex()
    //        reg.Split("");
    //     string[] ff=   reg.Split(infoAll);
    //     return;

    //    }
    //} 
    #endregion
}
