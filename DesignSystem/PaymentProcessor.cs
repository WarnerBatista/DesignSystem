using PaymentManager.Payments;

namespace PaymentManager
{
    internal class PaymentProcessor
    {
        private readonly List<PaymentMethod> _payments = new();

        public void AddPayment(PaymentMethod payment)
        {
            _payments.Add(payment);
        }

        public void ProcessAll()
        {
            foreach (var payment in _payments)
            {
                payment.ProcessPayment();
            }
        }

    }
}
