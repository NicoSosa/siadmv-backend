using AutoMapper;
using SiadMV.DataAccess.Contexts;
using EmpanadUS.ServiceBase.DAL.Infrastructure.Queries;
using EmpanadUS.ServiceBase.DAL.SeedWork;

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
