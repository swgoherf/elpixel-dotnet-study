using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task3
{
    public class CreditCard : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата {amount:C} успешно произведена кредитной картой");
        }
    }
}
