using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class CommonExpressionKeyFactConfiguration : IEntityTypeConfiguration<CommonExpressionKeyFact>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<CommonExpressionKeyFact> builder)
        {
            builder.Property(cekf => cekf.KeyFactId).ValueGeneratedNever().IsRequired();
            builder.Property(cekf => cekf.CommonExpressionId).ValueGeneratedNever().IsRequired();

            builder.HasOne(cekf => cekf.KeyFact)
                .WithMany(kf => kf.CommonExpressions)
                .HasForeignKey(cekf => cekf.KeyFactId);

            builder.HasOne(cekf => cekf.CommonExpression)
                .WithMany(q => q.KeysFact)
                .HasForeignKey(cekf => cekf.CommonExpressionId);
        }
    }
}
