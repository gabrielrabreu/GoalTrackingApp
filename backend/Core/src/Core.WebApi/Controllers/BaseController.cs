using Microsoft.AspNetCore.Mvc;

namespace Core.WebApi.Controllers
{
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    public abstract class BaseController : ControllerBase
    {
    }
}
