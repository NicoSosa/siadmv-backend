using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using EmpanadUS.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class CartProductConfiguration : IEntityTypeConfiguration<CartProduct>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<CartProduct> builder)
        {
            builder.SetupBaseEntity<CartProduct, Guid>();

            builder.Property(cp => cp.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(cp => cp.CartId).IsRequired();
            builder.Property(cp => cp.ProductId).IsRequired();
            builder.Property(cp => cp.Quantity).IsRequired();

            builder.HasOne(cp => cp.Cart)
                .WithMany(c => c.CartProducts)
                .HasForeignKey(cp => cp.CartId);
        }
    }
}
