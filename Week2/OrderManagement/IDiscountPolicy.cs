using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public interface IDiscountPolicy
    {
        decimal ApplyDiscount(decimal total);
    }
}
