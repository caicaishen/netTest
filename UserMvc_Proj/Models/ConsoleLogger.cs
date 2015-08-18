using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMvc_Proj.Interfaces;

namespace UserMvc_Proj.Models
{
    public class ConsoleLogger:ILogger
    {

        #region ILogger成员
        public string  Log(string value)
        {
          //  Console.WriteLine(String.Format("ConsoleLogger:{0}", value));
            return String.Format("ConsoleLogger:{0}", value);
        } 
        #endregion
    }

    public class NullLogger : ILogger
    {

        #region ILogger成员
        public string  Log(string value)
        {
            return "NullLogger:Hey,Nothing to do!";
           // Console.WriteLine("NullLogger:Hey,Nothing to do!");
        }
        #endregion
    }
}