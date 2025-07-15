namespace ShippingAPI
{
    public interface ICanShip
    {
        void Ship();
        bool CanShipTo(string country);
    }
}