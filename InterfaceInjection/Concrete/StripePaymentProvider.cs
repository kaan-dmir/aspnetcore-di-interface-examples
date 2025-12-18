using InterfaceInjection.Abstract;

namespace InterfaceInjection.Concrete
{
    public class StripePaymentProvider : IPaymentProvider
    {
        public string Pay(decimal amount)
        {
            // Stripe ile ödeme entegrasyonu burada yapılır.
            return $"{amount} TL Stripe ile ödendi";
        }
    }
}

