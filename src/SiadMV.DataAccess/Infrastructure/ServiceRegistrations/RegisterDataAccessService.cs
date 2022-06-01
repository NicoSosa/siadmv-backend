using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Infrastructure.Enums;
using SiadMV.DataAccess.Infrastructure.Extensions;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.IdentityDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Queries.SiadMVDb;
using SiadMV.DataAccess.Queries.IdentityDb;
using SiadMV.DataAccess.UnitOfWork;
using SiadMV.ServiceBase.DAL.Infrastructure.Extensions;
using SiadMV.ServiceBase.SeedWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SiadMV.DataAccess.Infrastructure.ServiceRegistrations
{
    public class RegisterDataAccessService : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            RegisterSiadMVDbServices(services);
            RegisterIdentityDbServices(services);

            services.RunDbMigrations();
        }

        private void RegisterSiadMVDbServices(IServiceCollection services)
        {
            services.AddDbContext<SiadMVDbContext>(nameof(AvailableDatabase.SiadMVDb));
            services.AddScoped<ISiadMVDbUoW, SiadMVDbUoW>();

            services.AddScoped<ICommonExpressionQueryBuilder, CommonExpressionQueryBuilder>();
            services.AddScoped<ICommonExpressionKeyFactQueryBuilder, CommonExpressionKeyFactQueryBuilder>();
            services.AddScoped<IKeyFactQueryBuilder, KeyFactQueryBuilder>();
            services.AddScoped<IQuestionKeyFactQueryBuilder, QuestionKeyFactQueryBuilder>();
            services.AddScoped<IQuestionQueryBuilder, QuestionQueryBuilder>();
            services.AddScoped<IUserCaseQueryBuilder, UserCaseQueryBuilder>();
        }

        private void RegisterIdentityDbServices(IServiceCollection services)
        {
            services.AddDbContext<IdentityDbContext>(nameof(AvailableDatabase.IdentityDb));
            services.AddScoped<IIdentityDbUoW, IdentityDbUoW>();

            services.AddScoped<IUserIdentityQueryBuilder, UserIdentityQueryBuilder>();
            services.AddScoped<IUserAddressQueryBuilder, UserAddressQueryBuilder>();
            services.AddScoped<IUserProviderQueryBuilder, UserProviderQueryBuilder>();
        }
    }
}
