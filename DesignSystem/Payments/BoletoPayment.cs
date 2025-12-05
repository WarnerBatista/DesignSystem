namespace PaymentManager.Payments
{
    internal class BoletoPayment : PaymentMethod
    {
        public DateOnly DueDate { get; set; }

        public BoletoPayment(DateOnly dueDate, long amount) : base(amount)
        {
            DueDate = dueDate;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processando pagamento via Boleto...");
            Thread.Sleep(1000);
            Console.WriteLine("Geração de código de barras, no valor de: {0} foi finalizado!", Amount);
        }
    }
}
