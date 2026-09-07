using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task3
{
    public class PayPal : IPaymentProcessor 
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата {amount:C} успешно произведена PayPal");
        }
    }
}
