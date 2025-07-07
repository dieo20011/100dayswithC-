using System;

namespace ShippingAPI.Models
{
    public class Order : ICanShip
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public string DestinationCountry { get; set; }
        public OrderStatusEnum Status { get; set; } = OrderStatusEnum.Processing;

        public bool CanShipTo(string country)
        {
            return string.Equals(country, "Vietnam", StringComparison.OrdinalIgnoreCase);
        }


        public void Ship()
        {
            if (CanShipTo(DestinationCountry))
                Status = OrderStatusEnum.Shipped;
            else
                Status = OrderStatusEnum.Processing;
        }
    }
} 