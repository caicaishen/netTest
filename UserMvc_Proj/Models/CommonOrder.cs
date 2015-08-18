using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserMvc_Proj.Interfaces;

namespace UserMvc_Proj.Models
{
    public class CommonOrder:IOrder
    {
        private double discount;

        public double Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

        public string  DumpDiscount()
        {
            return String.Format("CommonOrder:{0}",discount);
        }
    }



    public class VipOrder : IOrder
    {
        private double discount;

        public double Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

        public string DumpDiscount()
        {
            return String.Format("VipOrder{0}", discount);
        }
    }
}