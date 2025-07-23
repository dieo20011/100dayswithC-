namespace OrderManagement
{
   public class OrderCalculator
    {
        public static decimal CalculateTotalPrice(Order order, IDiscountPolicy discountPolicy)
        {
            if (order == null || order.Items == null || !order.Items.Any())
            {
                return 0;
            }
            decimal total = order.Items.Sum(item => item.getTotalPrice());

            return discountPolicy.ApplyDiscount(total);
        }
    }
}
