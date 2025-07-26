using System;
namespace OrderManagement
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid Credit Card: {amount:C}");
        }
    }
}