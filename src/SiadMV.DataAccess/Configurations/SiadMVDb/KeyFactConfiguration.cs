using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class KeyFactConfiguration : IEntityTypeConfiguration<KeyFact>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<KeyFact> builder)
        {
            builder.SetupBaseEntity<KeyFact, Guid>();

            builder.Property(kf => kf.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(kf => kf.CreationDate).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAdd().IsRequired();
            builder.Property(kf => kf.Description).IsRequired().HasMaxLength(1024);
        }
    }
}
