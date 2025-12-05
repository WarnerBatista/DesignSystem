namespace PaymentManager.Payments
{
    internal abstract class PaymentMethod
    {
        public long Amount { get; set; }

        protected PaymentMethod(long amount)
        {
            Amount = amount;
        }

        public abstract void ProcessPayment();
    }
}
