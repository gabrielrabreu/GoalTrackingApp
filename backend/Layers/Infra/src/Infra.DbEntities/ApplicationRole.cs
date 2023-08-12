using Microsoft.AspNetCore.Identity;

namespace Infra.DbEntities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}
