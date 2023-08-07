using Health.Application.Interfaces;
using Health.Application.Services;

namespace Health.UnitTest.Services
{
    public class HealthServiceTest
    {
        private readonly IHealthService _healthService;

        public HealthServiceTest()
        {
            _healthService = new HealthService();
        }

        [Fact]
        public void Health_ShouldReturnTrue()
        {
            // Act
            var result = _healthService.Health();

            // Assert
            result.Should().BeTrue();
        }
    }
}
