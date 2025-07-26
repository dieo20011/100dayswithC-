namespace OrderManagement
{
    public class AdminUser : IOrderViewer, IProductManager, IIsAdmin
    {
        public void ViewOrder()
        {
            Console.WriteLine("Admin View Order");
        }
        public void ManageProducts()
        {
            Console.WriteLine("Admin Manage Products");
        }
        public bool IsAdmin(string email)
        {
            return string.Equals(email, "admin@gmail.com", StringComparison.OrdinalIgnoreCase);
        }
    }
}