using homework1._2.Task2;
using homework1._2.Task3;

var employees = new List<Employee>
            {
                new Developer("Алексей", 150000),
                new Manager("Мария", 120000),
                new Designer("Елена", 100000)
            };

double amountToPay = 150.00;

IPaymentProcessor creditCardProcessor = new CreditCard();
PaymentService creditCardService = new PaymentService(creditCardProcessor);
creditCardService.Pay(amountToPay);

IPaymentProcessor payPalProcessor = new PayPal();
PaymentService payPalService = new PaymentService(payPalProcessor);
payPalService.Pay(amountToPay);

IPaymentProcessor cryptoProcessor = new CryptoPayment();
PaymentService cryptoService = new PaymentService(cryptoProcessor);
cryptoService.Pay(amountToPay);