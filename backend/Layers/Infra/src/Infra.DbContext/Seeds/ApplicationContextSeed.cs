using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DbContext.Seeds
{
    public static class ApplicationContextSeed
    {
        public static void Migrate(this IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
        }

        public static void Seed(this IServiceProvider services)
        {
            using var scope = services.CreateScope();

            RoleSeed.Seed(scope.ServiceProvider).Wait();
        }
    }
}
