using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMvc_Proj.Interfaces;

namespace UserMvc_Proj.Models
{
    public class PropertyInjection:IOrderWithLogging
    {
        private IOrder order;
        private ILogger logger;

        [Dependency]
        public IOrder MyOrder {

            get { return order; }
            set { order = value; }
        
        }
        [Dependency]
        public ILogger MyLogger
        {
            get { return logger; }
            set { logger = value; }
        }
        public string Output()
        {
            string mm = order.DumpDiscount();
            mm += "kong kong " + logger.Log(string.Format("{0}", order.Discount));
            return mm;
        }
    }
}