using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Infrastructure.Enums;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using SiadMV.ServiceBase.DAL.Infrastructure.Factories;
using Microsoft.EntityFrameworkCore;

namespace SiadMV.DataAccess.Contexts
{
    public class IdentityDbContext : CustomDbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserIdentity> UserIdentities { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UserProvider> UserProviders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder
                .ApplyConventions()
                .ApplyConfigurationsFromAssembly(GetType().Assembly, typeof(IIdentityDbConfiguration));
        }
    }

    public class IdentityDbContextDesignFactory : CustomDbContextDesignFactory<IdentityDbContext>
    {
        protected override string AppSettingsFile => "appsettings.local.json";
        protected override string DbName => nameof(AvailableDatabase.IdentityDb);
    }
}
