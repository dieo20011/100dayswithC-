using System;

public class Order : ICanShip
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }
    public string DestinationCountry { get; set; }
    public OrderStatusEnum Status { get; set; }

    public bool CanShipTo(string country)
    {
        return country == "Vietnam";
    }

    public void Ship()
    {
        if (CanShipTo(DestinationCountry))
        {
            Status = OrderStatusEnum.Shipped;
        }
        else
        {
            Status = OrderStatusEnum.Processing;
        }
    }
}