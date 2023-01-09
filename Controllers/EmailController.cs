using Microsoft.AspNetCore.Mvc;

namespace Email_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailServices _emailServices;

        public EmailController(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }

        [HttpPost]
        public IActionResult  SendEmail(string body)
        {
            _emailServices.SendEmail(Request)
            return Ok();
        }
    }
}
