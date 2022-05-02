using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public static class UserCaseExpressions
    {
        public static Expression<Func<UserCase, bool>> UserCaseIdFilter(Guid userCaseId)
            => PredicateBuilder.New<UserCase>().And(uc => uc.Id == userCaseId);

        public static Expression<Func<UserCase, bool>> asdUsercaseidfilter()
            => PredicateBuilder.New<UserCase>().And(uc => (uc.Id != Guid.Empty));

    }
}
