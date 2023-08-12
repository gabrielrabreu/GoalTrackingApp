using Infra.DbEntities;

namespace Security.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(ApplicationUser user, IEnumerable<string> roles);
    }
}
