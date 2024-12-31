using FactoryDemo;

var payment = PaymentFactory.create(PaymentMethod.CreditCard);
payment.Pay(10000);