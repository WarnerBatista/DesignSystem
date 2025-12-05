using PaymentManager.Payments;

namespace PaymentManager
{
    internal class PaymentMethodFactory
    {
        public PaymentMethod Create(int cardNumber, string expirationDate, byte cVV, long amount)
        {
            return new CreditCardPayment(cardNumber, expirationDate, cVV, amount);
        }

        public PaymentMethod Create(string pixKey, long amount)
        {
            return new PixPayment(pixKey, amount);
        }

        public PaymentMethod Create(DateOnly dueDate, long amount)
        {
            return new BoletoPayment(dueDate, amount);
        }
    }
}
