using Business.Abstract;
using DTO.Payment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _service;

        public PaymentController(IPaymentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

        [HttpGet("GetAllForReport")]

        public IActionResult GetAllForReport()
        {
            var data = _service.GetAllForReport();
            return Ok(data);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(CreatePaymentRequest payment)
        {
            var response = _service.Insert(payment);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(UpdatePaymentRequest payment)
        {
            var response = _service.Update(payment);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(Payment payment)
        {
            var response = _service.Delete(payment);
            return Ok(response);
        }
    }
}
