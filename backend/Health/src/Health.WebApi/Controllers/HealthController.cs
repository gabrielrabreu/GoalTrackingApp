using Health.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Health.WebApi.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;

        public HealthController(IHealthService healthService)
        {
            _healthService = healthService;
        }

        [HttpGet]
        public IActionResult Health()
        {
            if (_healthService.Health())
                return Ok();

            return StatusCode(StatusCodes.Status503ServiceUnavailable, null);
        }
    }
}
