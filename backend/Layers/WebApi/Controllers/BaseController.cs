using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    public abstract class BaseController : ControllerBase
    {
    }
}
