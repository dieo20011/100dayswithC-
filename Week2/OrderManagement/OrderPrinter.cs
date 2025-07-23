using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
   public static class OrderPrinter
    {
        public static void PrintOrderDetails(Order order, IDiscountPolicy discountPolicy, Decimal discountPercent)
        {
            Console.WriteLine("===== Order Details =====");
            Console.WriteLine($"Created Date: {order.CreatedDate}");

            foreach (var item in order.Items)
            {
                Console.WriteLine($"Product: {item.Product.Name}, Quantity: {item.Quantity}, Unit Price: {item.Product.Price:C}, Total: {item.getTotalPrice():C}");
            }

            decimal total = OrderCalculator.CalculateTotalPrice(order, discountPolicy);
            Console.WriteLine($"Discount Percents: {discountPercent} %");
            Console.WriteLine($"Total Amount: {total:C}");
            Console.WriteLine("=========================");
        }
    }
}
