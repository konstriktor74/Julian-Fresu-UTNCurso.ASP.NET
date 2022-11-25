using Microsoft.AspNetCore.Mvc;

namespace UTNCursoApi.Controllers.v2
{
    public class HealthCheck : Controller
    {
        [ApiVersion("2.0")]
        [ApiController]
        [Route("[controller]")]
        public class HealthCheckController : ControllerBase
        {
            [HttpGet("v{version:apiVersion}")]
            public IActionResult Get()
            {
                return Ok("OK");
            }

        }
    }
}
