using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.ServiceBase.DAL.Infrastructure.Queries;
using SiadMV.ServiceBase.DAL.SeedWork;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
	public abstract class SiadMVDbQueryBuilder<TEntity, TQueryBuilder> : QueryBuilder<SiadMVDbContext, TEntity, TQueryBuilder>
		where TEntity : class, IDataUnit
		where TQueryBuilder : class, IQueryBuilder
	{
		protected SiadMVDbQueryBuilder(SiadMVDbContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
