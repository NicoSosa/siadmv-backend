using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Infrastructure.Enums;
using SiadMV.DataAccess.Models.SiadMVDb;
using EmpanadUS.ServiceBase.DAL;
using EmpanadUS.ServiceBase.DAL.Infrastructure.Extensions;
using EmpanadUS.ServiceBase.DAL.Infrastructure.Factories;
using Microsoft.EntityFrameworkCore;

namespace SiadMV.DataAccess.Contexts
{
    public class SiadMVDbContext : CustomDbContext
    {
        public SiadMVDbContext(DbContextOptions<SiadMVDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartProduct> CartProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConventions()
                .ApplyConfigurationsFromAssembly(GetType().Assembly, typeof(ISiadMVDbConfiguration));
        }
    }

    public class SiadMVDbContextDesignFactory : CustomDbContextDesignFactory<SiadMVDbContext>
    {
        protected override string AppSettingsFile => "appsettings.local.json";

        protected override string DbName => nameof(AvailableDatabase.SiadMVDb);
    }
}
