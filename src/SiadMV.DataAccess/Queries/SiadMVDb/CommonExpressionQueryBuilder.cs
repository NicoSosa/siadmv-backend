using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;
namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class CommonExpressionQueryBuilder : SiadMVDbQueryBuilder<CommonExpression, ICommonExpressionQueryBuilder>, ICommonExpressionQueryBuilder
    {
        public CommonExpressionQueryBuilder(SiadMVDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public ICommonExpressionQueryBuilder FilterByCommonExpressionIdAsync(Guid commonExpressionId)
            => FilterBy(CommonExpExpressions.CommonExpressionIdFilter(commonExpressionId));

        public ICommonExpressionQueryBuilder IncludeKeysFact()
            => Include(ce => ce.KeysFact);
    }
}
