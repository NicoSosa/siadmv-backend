using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.IdentityDb
{
    class UserProviderConfiguration: IEntityTypeConfiguration<UserProvider>, IIdentityDbConfiguration
    {
        public void Configure(EntityTypeBuilder<UserProvider> builder)
        {
            builder.Property(up => up.Id).IsRequired().HasMaxLength(50);
            builder.Property(up => up.UserIdentityId).ValueGeneratedNever().IsRequired();
            builder.Property(up => up.UserProviderValue).IsRequired();

            builder.HasOne(up => up.UserIdentity)
                .WithMany(ui => ui.Providers)
                .HasForeignKey(up => up.UserIdentityId);
        }
    }
}
