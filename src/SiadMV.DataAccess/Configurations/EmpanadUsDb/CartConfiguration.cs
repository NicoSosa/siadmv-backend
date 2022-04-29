using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using EmpanadUS.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.SetupBaseEntity<Cart, Guid>();

            builder.Property(c => c.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(c => c.CreationDate).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAdd().IsRequired();
            builder.Property(c => c.UserIdentityId).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.RefreshCartDate).IsRequired();
            builder.Property(c => c.CartProducts).IsRequired();
        }
    }
}
