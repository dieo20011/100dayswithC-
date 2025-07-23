using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class FixedAmountDiscount : IDiscountPolicy
    {
        private readonly  decimal _amount;

        public FixedAmountDiscount(decimal amount)
        {
            _amount = amount;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - _amount < 0 ? 0 : total - _amount;
        }
    }
}
