using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.ServiceBase.DAL.Infrastructure.Queries;
using SiadMV.ServiceBase.DAL.SeedWork;

namespace SiadMV.DataAccess.Infrastructure.Queries.IdentityDb
{
    public abstract class IdentityDbQueryBuilder<TEntity, TQueryBuilder> : QueryBuilder<IdentityDbContext, TEntity, TQueryBuilder>
        where TEntity : class, IDataUnit
        where TQueryBuilder : class, IQueryBuilder
    {
        protected IdentityDbQueryBuilder(IdentityDbContext context, IMapper mapper)
            : base (context, mapper) 
        { 
        }
    }
}
