namespace OrderManagement
{
    public class CustomerUser : IOrderViewer
    {
        public void ViewOrder()
        {
            Console.WriteLine("Customer View Order");
        }
    }
}