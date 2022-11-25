using Microsoft.AspNetCore.Mvc;

namespace UTNCursoApi.Controllers.v1
{
    public class HealthCheck : Controller
    {
        [ApiVersion("1.0")]
        [ApiController]
        [Route("[controller]")]
        public class HealthCheckController : ControllerBase
        {
            [HttpGet()]
            public IActionResult Get()
            {
                return Ok();
            }

        }
    }
}
