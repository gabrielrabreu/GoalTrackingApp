using Microsoft.Extensions.DependencyInjection;
using Security.Application.Interfaces;
using Security.Application.Services;

namespace Security.IoC
{
    public static class SecurityBootstrapper
    {
        public static void AddSecurityServices(this IServiceCollection services)
        {
            Application(services);
        }

        private static void Application(IServiceCollection services)
        {
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}