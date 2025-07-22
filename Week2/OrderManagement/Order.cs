namespace OrderManagement
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTime CreatedDate { get; set; }

        public Order()
        {
            CreatedDate = DateTime.Now;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }
}
