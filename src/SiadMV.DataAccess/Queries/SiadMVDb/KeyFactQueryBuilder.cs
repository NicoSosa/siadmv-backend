using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;

namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class KeyFactQueryBuilder : SiadMVDbQueryBuilder<KeyFact, IKeyFactQueryBuilder>, IKeyFactQueryBuilder
    {
        public KeyFactQueryBuilder(SiadMVDbContext context, IMapper mapper)
            : base(context, mapper) 
        { 
        }

        public IKeyFactQueryBuilder FilterByKeyFactIdAsync(Guid keyFactId)
            => FilterBy(KeyFactExpressions.KeyFactIdFilter(keyFactId));

        public IKeyFactQueryBuilder IncludeCommonExpressions()
            => Include(kf => kf.CommonExpressions);

        public IKeyFactQueryBuilder IncludeQuestions()
            => Include(kf => kf.Questions);
    }
}