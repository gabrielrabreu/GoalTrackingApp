using Security.Application.Interfaces;

namespace Security.Application.Services
{
    public class SessionService : ISessionService
    {
        public Guid? User { get; private set; }

        public void Authenticate(Guid user)
        {
            User = user;
        }
    }
}
