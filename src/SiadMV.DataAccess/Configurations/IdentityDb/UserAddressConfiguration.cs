using SiadMV.DataAccess.Enums;
using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.IdentityDb
{
    public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>, IIdentityDbConfiguration
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.SetupBaseEntity<UserAddress, Guid>();

            builder.Property(ua => ua.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(ua => ua.CreationDate).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(ua => ua.Address1).HasMaxLength(150).HasDefaultValue(null);
            builder.Property(ua => ua.Address2).HasMaxLength(150).HasDefaultValue(null);
            builder.Property(ua => ua.City).HasMaxLength(50).IsRequired();
            builder.Property(ua => ua.State).HasMaxLength(50).IsRequired();
            builder.Property(ua => ua.Zipcode).HasMaxLength(5).IsRequired();
            builder.Property(ua => ua.UserIdentityId).ValueGeneratedNever().IsRequired();

            builder.HasOne(ua => ua.UserIdentity)
                .WithMany(ui => ui.Addresses)
                .HasForeignKey(ua => ua.UserIdentityId);
        }
    }
}
