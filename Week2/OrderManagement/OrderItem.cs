﻿namespace OrderManagement
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal getTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }
}
