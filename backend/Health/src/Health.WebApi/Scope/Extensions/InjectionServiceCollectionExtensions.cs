using Health.Infra.CrossCutting.IoC;

namespace Health.WebApi.Scope.Extensions
{
    public static class InjectionServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            HealthBootstrapper.Load(services);
        }
    }
}
