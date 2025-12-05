using PaymentManager;

var factory = new PaymentMethodFactory();

var creditCardPayment = factory.Create(1234, "12/2030", 123, 100);
var pixPayment = factory.Create("pixkey", 100);
var boletoPayment = factory.Create(new DateOnly(2025, 12, 10), 200);

var paymentProcessor = new PaymentProcessor();

paymentProcessor.AddPayment(creditCardPayment);
paymentProcessor.AddPayment(pixPayment);
paymentProcessor.AddPayment(boletoPayment);

paymentProcessor.ProcessAll();

