using OrderManagement;class Program
{
      static void Main(string[] args)
    {
        var product1 = new Product(1, "Laptop", 1500.00m);
        var product2 = new Product(2, "Smartphone", 800.00m);
        var discountPercent = 10;

        var order = new Order
        {
            CreatedDate = DateTime.Now,
            Items = new List<OrderItem>
            {
                new OrderItem(product1, 1),
                new OrderItem(product2, 2)
            }
        };
        IDiscountPolicy discountPolicy = new PercentageDiscount(discountPercent);
        OrderPrinter.PrintOrderDetails(order, discountPolicy, discountPercent);
    }
}