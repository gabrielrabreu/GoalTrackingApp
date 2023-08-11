using Core.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V1
{
    public class HealthController : BaseController
    {
        private readonly IApplicationDbContext _context;

        public HealthController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Health()
        {
            var result = _context.CanConnect();

            if (result) 
                return Ok();

            return BadRequest();
        }
    }
}
