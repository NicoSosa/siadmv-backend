using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;

namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class CommonExpressionKeyFactQueryBuilder : SiadMVDbQueryBuilder<CommonExpressionKeyFact, ICommonExpressionKeyFactQueryBuilder>, ICommonExpressionKeyFactQueryBuilder
    {
        public CommonExpressionKeyFactQueryBuilder(SiadMVDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public ICommonExpressionKeyFactQueryBuilder FilterByCommonExpressionIdAsync(Guid commonExpressionId)
            => FilterBy(CommonExpKeyFactExpressions.CEKFByCommonExpresionIdFilter(commonExpressionId));
        public ICommonExpressionKeyFactQueryBuilder FilterByKeyFactIdAsync(Guid keyFactId)
            => FilterBy(CommonExpKeyFactExpressions.CEKFByKeyFactIdFilter(keyFactId));
        public ICommonExpressionKeyFactQueryBuilder FilterByCommonExpressionKeyFactIdAsync(Guid commonExpressionId, Guid keyFactId)
            => FilterBy(CommonExpKeyFactExpressions.CEKFByCommonExpresionAndKeyFactIdFilter(commonExpressionId, keyFactId));

    }
}
