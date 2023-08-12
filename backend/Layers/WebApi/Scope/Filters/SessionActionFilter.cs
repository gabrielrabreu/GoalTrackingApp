using Infra.DbEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Security.Application.Interfaces;

namespace WebApi.Scope.Filters
{
    public class SessionActionFilter : IActionFilter
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISessionService _sessionService;

        public SessionActionFilter(UserManager<ApplicationUser> userManager, 
                                   ISessionService sessionService)
        {
            _userManager = userManager;
            _sessionService = sessionService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var identity = context.HttpContext.User.Identity;

            if (identity != null && identity.IsAuthenticated)
            {
                var user = _userManager.GetUserAsync(context.HttpContext.User).Result;
                if (user != null)
                {
                    _sessionService.Authenticate(user.Id);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
