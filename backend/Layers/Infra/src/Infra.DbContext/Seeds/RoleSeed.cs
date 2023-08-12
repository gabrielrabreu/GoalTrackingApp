using Infra.DbEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DbContext.Seeds
{
    public static class RoleSeed
    {
        public static async Task Seed(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            var roles = new string[] { "Admin", "Manager", "User" };

            foreach (var roleName in roles)
            {
                var roleExists = await roleManager.RoleExistsAsync(roleName);

                if (!roleExists)
                {
                    await roleManager.CreateAsync(new ApplicationRole(roleName));
                }
            }
        }
    }
}
