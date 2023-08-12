namespace Security.Application.Interfaces
{
    public interface ISessionService
    {
        Guid? User { get; }

        void Authenticate(Guid user);
    }
}
