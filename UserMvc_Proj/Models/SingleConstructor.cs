using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMvc_Proj.Interfaces;

namespace UserMvc_Proj.Models
{
    public class SingleConstructor:IOrderWithLogging
    {
        private IOrder order;
        private ILogger logger;
        public SingleConstructor(IOrder order, ILogger logger) {
            this.order = order;
            this.logger = logger;
        
        }
        public string Output()
        {
            string mm = order.DumpDiscount();
            mm += "kong ge";
            mm += logger.Log(string.Format("{0}", order.Discount));

            return mm;
        }
    }
}