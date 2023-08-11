namespace Core.Infra.Data.Context
{
    public interface IApplicationDbContext
    {
        bool CanConnect();
    }
}
