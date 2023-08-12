using Security.IoC;

namespace WebApi.Scope.Extensions
{
    public static class InjectionServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddSecurityServices();
        }
    }
}
