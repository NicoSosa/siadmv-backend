using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class UserCaseConfiguration : IEntityTypeConfiguration<UserCase>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<UserCase> builder)
        {
            builder.SetupBaseEntity<UserCase, Guid>();

            builder.Property(us => us.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(us => us.CreationDate).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAdd().IsRequired();
            builder.Property(us => us.Description).IsRequired().HasMaxLength(1024);
        }
    }
}
