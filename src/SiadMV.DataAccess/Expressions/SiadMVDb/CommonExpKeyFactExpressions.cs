using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public class CommonExpKeyFactExpressions
    {
        public static Expression<Func<CommonExpressionKeyFact, bool>> CEKFByKeyFactIdFilter(Guid keyFactId)
            => PredicateBuilder.New<CommonExpressionKeyFact>().And(cekf => cekf.KeyFactId == keyFactId);
        public static Expression<Func<CommonExpressionKeyFact, bool>> CEKFByCommonExpresionIdFilter(Guid commonExpressionId)
            => PredicateBuilder.New<CommonExpressionKeyFact>().And(cekf => cekf.CommonExpressionId == commonExpressionId);
        public static Expression<Func<CommonExpressionKeyFact, bool>> CEKFByCommonExpresionAndKeyFactIdFilter(Guid commonExpressionId, Guid keyFactId)
            => PredicateBuilder.New<CommonExpressionKeyFact>().And(cekf => cekf.CommonExpressionId == commonExpressionId && cekf.KeyFactId == keyFactId);
    }
}
