using InterfaceInjection.Business;
using InterfaceInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceInjection.Controllers
{
    public class PaymentController : Controller
    {
        private readonly PaymentManager _paymentManager;
        public PaymentController(PaymentManager paymentManager)
        {
            // Controller'a bir istek geldiğinde, constructor, PaymentManager nesnesine ihtiyaç olduğunu söyler.
            _paymentManager = paymentManager;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Pay(PaymentRequest request)
        {
            // ** Controller: İş kuralı yazmaz (ödeme şartları vs.)
            // Sadece isteği alır ve business katmanına iletir
            var resultMessage = _paymentManager.MakePayment(request.Amount);
            return Ok(resultMessage);
        }
    }
}
