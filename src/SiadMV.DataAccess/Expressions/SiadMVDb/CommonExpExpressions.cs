using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public class CommonExpExpressions
    {
        public static Expression<Func<CommonExpression, bool>> CommonExpressionIdFilter(Guid commonExpressionId)
            => PredicateBuilder.New<CommonExpression>().And(ce => ce.Id == commonExpressionId);
    }
}
