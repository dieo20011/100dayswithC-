namespace OrderManagement
{
   public class OrderCalculator
    {
        public static decimal CalculateTotalPrice(Order order)
        {
            if (order == null || order.Items == null || !order.Items.Any())
            {
                return 0;
            }
            decimal total = 0;
            foreach (var item in order.Items)
            {
                total += item.getTotalPrice();
            }
            return total;
        }
    }
}
