using InterfaceInjection.Abstract;

namespace InterfaceInjection.Business
{

    // PaymentManager sınıfı, somut ödeme sağlayıcılarını değil yalnızca IPaymentProvider interface'ini tanır.
    public class PaymentManager
    {
        private readonly IPaymentProvider _paymentProvider; 

        public PaymentManager(IPaymentProvider paymentProvider) // Dependency Injection burada devreye giriyor. PaymentManager, bir IPaymentProvider ister. Hangi ödeme sistemi kullanacağını umursamaz.
                                                                                                                                                                     
                                                               
        {
            _paymentProvider = paymentProvider;
        }
        public string MakePayment(decimal amount)
        {
            // Ödeme ile ilgili yapılacak genel tüm iş kuralları tanımlanır.
            if (amount <= 0)
            {
                Console.WriteLine("Ödeme tutarı 0'dan büyük olmalıdır");
                return "Ödeme tutarı 0'dan büyük olmalıdır";
            }
            return _paymentProvider.Pay(amount);  // Ödeme işlemi interface üzerinden gerçekleştirilir

            // PaymentManager: Stripe, Paypal veya başka bir entegrasyon ile ödemenin nasıl alınacağıyla ilgilenmiyor. Bildiği tek şey, IPaymentProvider varsa, ödeme yapılabilir.  _paymentProvider ise runtime da ilgili ödeme sistemine (PaypalPaymentProvider veya StripePaymentProvider) dönüşür. Ve bu sayede ilgili ödeme sisteminde ki Pay metodu  ilgili ödeme sisteminin kendi implementasyonu çağrılmış olur.



        }
    }
}
