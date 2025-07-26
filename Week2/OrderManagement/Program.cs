using OrderManagement;class Program
{
      static void Main(string[] args)
    {
        var product1 = new Product(1, "Laptop", 1500.00m);
        var product2 = new Product(2, "Smartphone", 800.00m);
        var discountPercent = 10;
        var userName = "admin22@gmail.com";

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
        
        IPaymentMethod paymentMethod;
        decimal totalAmount = OrderCalculator.CalculateTotalPrice(order, discountPolicy);
        paymentMethod = new CashPayment();
        paymentMethod.Pay(totalAmount);
        

        paymentMethod = new CreditCardPayment();
        paymentMethod.Pay(totalAmount);

        //User Viewer
        IOrderViewer customerViewerOrder = new CustomerUser();
        customerViewerOrder.ViewOrder();

        // Admin User

        IOrderViewer adminViewerOrder = new AdminUser();
        IProductManager adminManageProduct = new AdminUser();
        var user = new AdminUser();
        if (user.IsAdmin(userName))
        {
            adminManageProduct.ManageProducts();
            adminViewerOrder.ViewOrder();
        }

    }
}