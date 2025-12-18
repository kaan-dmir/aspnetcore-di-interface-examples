using InterfaceInjection.Abstract;

namespace InterfaceInjection.Concrete
{
    public class PaypalPaymentProvider : IPaymentProvider
    {
        public string Pay(decimal amount)
        {
            // PayPal ile ödeme entegrasyonu burada yapılır.
            return $"{amount} TL PayPal ile ödendi";

        }
    }
}
