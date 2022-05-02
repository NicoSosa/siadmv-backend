using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace SiadMV.DataAccess.Configurations.SiadMVDb
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>, ISiadMVDbConfiguration
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.SetupBaseEntity<Question, Guid>();

            builder.Property(q => q.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(q => q.CreationDate).HasDefaultValue(DateTime.UtcNow).ValueGeneratedOnAdd().IsRequired();
            builder.Property(q => q.Description).IsRequired().HasMaxLength(1024);
        }
    }
}
