namespace ShippingAPI
{
    public class Order : ICanShip
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string DestinationCountry { get; set; } = string.Empty;
        public EOrderStatus Status { get; set; } = EOrderStatus.Processing;
        public bool CanShipTo(string country)
        {
            return string.Equals(country, "VietNam", StringComparison.OrdinalIgnoreCase);
        }

        public void Ship()
        {
            if (CanShipTo(DestinationCountry))
            {
                Status = EOrderStatus.Shipped;
            }
            else
            {
                Status = EOrderStatus.Processing;
            }
        }
    }
}
