using Core.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EntityFrameworkCoreContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Infra.DbContext
{
    public class ApplicationDbContext : EntityFrameworkCoreContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public bool CanConnect()
        {
            return Database.CanConnect();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
