using Health.Application.Interfaces;

namespace Health.Application.Services
{
    public class HealthService : IHealthService
    {
        public bool Health()
        {
            return false;
        }
    }
}
