using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
   public class NoDiscount : IDiscountPolicy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total;
        }
    }
}
