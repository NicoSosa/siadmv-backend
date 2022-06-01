using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class QuestionKeyFactConfiguration : IEntityTypeConfiguration<QuestionKeyFact>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<QuestionKeyFact> builder)
        {
            builder.Property(qkf => qkf.QuestionId).ValueGeneratedNever().IsRequired();
            builder.Property(qkf => qkf.KeyFactId).ValueGeneratedNever().IsRequired();

            builder.HasOne(qkf => qkf.Question)
                .WithMany(q => q.KeysFact)
                .HasForeignKey(qkf => qkf.QuestionId);

            builder.HasOne(qkf => qkf.KeyFact)
                .WithMany(kf => kf.Questions)
                .HasForeignKey(qkf => qkf.KeyFactId);
        }
    }
}
