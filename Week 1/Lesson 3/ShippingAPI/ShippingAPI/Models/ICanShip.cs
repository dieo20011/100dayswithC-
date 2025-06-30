namespace ShippingAPI.Models
{
    public interface ICanShip
    {
        void Ship();
        bool CanShipTo(string country);
    }
} 