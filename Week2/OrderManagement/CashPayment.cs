using System;
namespace OrderManagement
{
    public class CashPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid Cash: {amount:C}");
        }
    }
}