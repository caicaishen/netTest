using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMvc_Proj.Interfaces
{
  public   interface IOrder
    {
      double Discount
      { get; set; }
      string  DumpDiscount();
    }
}
