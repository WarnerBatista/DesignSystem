namespace PaymentManager.Payments
{
    internal class CreditCardPayment : PaymentMethod
    {
        public int CardNumber { get; set; }
        public string ExpirationDate { get; set; } = string.Empty;
        public byte CVV { get; set; }

        public CreditCardPayment(int cardNumber, string expirationDate, byte cVV, long amount) : base(amount)
        {
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            CVV = cVV;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Validando os dados do cartão...");
            Thread.Sleep(1000);
            Console.WriteLine("Processando pagamento via cartão de credito...");
            Thread.Sleep(1000);
            Console.WriteLine("Pagamento via cartão de credito, no valor de: {0} foi finalizado!", Amount);
        }
    }
}
