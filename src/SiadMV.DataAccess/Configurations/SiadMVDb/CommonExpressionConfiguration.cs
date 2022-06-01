using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class CommonExpressionConfiguration : IEntityTypeConfiguration<CommonExpression>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<CommonExpression> builder)
        {
            builder.SetupBaseEntity<CommonExpression, Guid>();

            builder.Property(ce => ce.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(ce => ce.CreationDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(ce => ce.Description).IsRequired().HasMaxLength(64);
        }
    }
}
