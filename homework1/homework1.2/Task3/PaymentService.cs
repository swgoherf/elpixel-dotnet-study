using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task3
{
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Pay(double amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
