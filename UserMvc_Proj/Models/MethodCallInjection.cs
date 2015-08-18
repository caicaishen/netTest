using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMvc_Proj.Interfaces;

namespace UserMvc_Proj.Models
{
    public class MethodCallInjection:IOrderWithLogging
    {
        private IOrder order;
        private ILogger logger;
        [InjectionMethod]
        public void Inject(IOrder order,ILogger logger)
        {
            this.order = order;
            this.logger = logger;
        }
        public string Output()
        {
            string mm = order.DumpDiscount();
            mm += "kong kong " + logger.Log(string.Format("{0}", order.Discount));
            return mm;
        }
    }
}