using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public static class KeyFactExpressions
    {
        public static Expression<Func<KeyFact, bool>> KeyFactIdFilter(Guid keyFactId)
            => PredicateBuilder.New<KeyFact>().And(kf => kf.Id == keyFactId);
    }
}
