using Microsoft.AspNetCore.Mvc;

namespace _4images.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, 4Images!");
        }
    }
}
