namespace InterfaceInjection.Models
{

    /// <summary>
    /// PaymentRequest sınıfı, ödeme işlemleri sırasında kullanılacak veri taşıma (DTO) modelimizdir.
    /// Bu sınıf yalnızca veriyi taşır, herhangi bir iş mantığı içermez.
    /// </summary>
    public class PaymentRequest
    {
        public decimal Amount { get; set; }
    }
}

