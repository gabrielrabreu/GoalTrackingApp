using Core.Infra.Data.Context;
using Infra.DbContext;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Scope.Extensions
{
    public static class DatabaseServiceCollectionExtensions
    {
        public static void AddCustomDatabase(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer("name=ConnectionStrings:SqlServer",
                    x => x.MigrationsAssembly(typeof(Infra.DbMigrations.Reference).Assembly.FullName)));
        }
    }
}
