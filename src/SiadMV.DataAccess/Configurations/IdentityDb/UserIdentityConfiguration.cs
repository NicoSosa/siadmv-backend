using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.IdentityDb
{
    public class UserIdentityConfiguration : IEntityTypeConfiguration<UserIdentity>, IIdentityDbConfiguration  
    {
        public void Configure(EntityTypeBuilder<UserIdentity> builder)
        {
            builder.SetupBaseEntity<UserIdentity, Guid>();

            builder.Property(ui => ui.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(ui => ui.CreationDate).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(ui => ui.Email).HasMaxLength(50).IsRequired();
            builder.Property(ui => ui.FirstName).HasMaxLength(100).HasDefaultValue(null);
            builder.Property(ui => ui.Surname).HasMaxLength(50).HasDefaultValue(null);
            builder.Property(ui => ui.Phone).HasMaxLength(11).HasDefaultValue(null);
            builder.Property(ui => ui.Addresses).IsRequired();
            builder.Property(ui => ui.Providers).IsRequired();
        }
    }
}
