using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class PercentageDiscount : IDiscountPolicy
    {
        public readonly decimal _percentage;
        public PercentageDiscount(decimal percentage) { 
            _percentage = percentage;
        }
        public decimal ApplyDiscount(decimal total)
        {
            if (_percentage < 0 || _percentage > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(_percentage), "Percentage must be between 0 and 100.");
            }
            return total - (total * _percentage / 100);
        }
    }
}
