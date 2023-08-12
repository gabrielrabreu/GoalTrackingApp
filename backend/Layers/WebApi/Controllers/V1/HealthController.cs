using Core.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Security.Application.Interfaces;

namespace WebApi.Controllers.V1
{
    public class HealthController : BaseController
    {
        private readonly IApplicationDbContext _context;
        private readonly ISessionService _sessionService;

        public HealthController(IApplicationDbContext context, ISessionService sessionService)
        {
            _context = context;
            _sessionService = sessionService;
        }

        [HttpGet]
        public IActionResult Health()
        {
            var result = _context.CanConnect();

            if (result) 
                return Ok(_sessionService.User);

            return BadRequest();
        }
    }
}
