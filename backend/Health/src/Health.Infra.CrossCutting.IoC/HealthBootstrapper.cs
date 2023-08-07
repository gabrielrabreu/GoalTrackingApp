using Health.Application.Interfaces;
using Health.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Health.Infra.CrossCutting.IoC
{
    public static class HealthBootstrapper
    {
        public static void Load(IServiceCollection services)
        {
            Application(services);
        }

        private static void Application(IServiceCollection services)
        {
            services.AddTransient<IHealthService, HealthService>();
        }
    }
}
