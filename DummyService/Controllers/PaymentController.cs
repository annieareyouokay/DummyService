using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DummyService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost("payment")]
        public async Task<ActionResult<bool>> CompletePaymentAsync(CancellationToken cancellationToken)
        {
            return await Task.Run(() => 
            {
                Random random = new Random();
                return Ok(random.Next(0, 100) > 50);
            });
        }
    }
}
