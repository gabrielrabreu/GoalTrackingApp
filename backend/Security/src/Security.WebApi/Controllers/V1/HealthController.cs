using Core.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Security.WebApi.Controllers.V1
{
    public class HealthController : BaseController
    {
        [HttpGet]
        public IActionResult Health()
        {
            return Ok();
        }
    }
}
