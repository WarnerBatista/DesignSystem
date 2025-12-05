namespace PaymentManager.Payments
{
    internal class PixPayment : PaymentMethod
    {
        public string PixKey { get; set; } = string.Empty;

        public PixPayment(string pixKey, long amount) : base(amount)
        {
            PixKey = pixKey;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processando pagamento via Pix...");
            Thread.Sleep(1000);
            Console.WriteLine("Pagamento via Pix, no valor de: {0} foi finalizado!", Amount);
        }
    }
}
