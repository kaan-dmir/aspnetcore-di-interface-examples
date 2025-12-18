namespace InterfaceInjection.Abstract
{

    /// <summary>
    /// IPaymentProvider, ödeme işlemlerini gerçekleştirecek servisler için bir sözleşme tanımlar.
    /// Tüm ödeme sağlayıcıları bu interface'i implement etmelidir.
    /// </summary>
    public interface IPaymentProvider
    {
        String Pay(decimal amount);
    }
}
