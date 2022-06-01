using SiadMV.DataAccess.Infrastructure.Configurations;
using SiadMV.DataAccess.Infrastructure.Enums;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using SiadMV.ServiceBase.DAL.Infrastructure.Factories;
using Microsoft.EntityFrameworkCore;

namespace SiadMV.DataAccess.Contexts
{
    public class SiadMVDbContext : CustomDbContext
    {
        public SiadMVDbContext(DbContextOptions<SiadMVDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CommonExpression> CommonExpresions{ get; set; }
        public virtual DbSet<CommonExpressionKeyFact> CommonExpressionsKeysFact { get; set; }
        public virtual DbSet<KeyFact> KeyFacts { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionKeyFact> QuestionsKeysFact { get; set; }
        public virtual DbSet<UserCase> UserCases { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommonExpressionKeyFact>().HasKey(cekf => new { cekf.CommonExpressionId, cekf.KeyFactId });
            modelBuilder.Entity<QuestionKeyFact>().HasKey(qkf => new { qkf.QuestionId, qkf.KeyFactId });

            modelBuilder
                .ApplyConventions()
                .ApplyConfigurationsFromAssembly(GetType().Assembly, typeof(ISiadMVDbConfiguration));
        }
    }

    public class SiadMVDbContextDesignFactory : CustomDbContextDesignFactory<SiadMVDbContext>
    {
        protected override string AppSettingsFile => "appsettings.local.json";

        protected override string DbName => nameof(AvailableDatabase.SiadMVDb);
    }
}
