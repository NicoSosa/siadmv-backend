using SiadMV.DataAccess.Models.IdentityDb;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SiadMV.DataAccess.Expressions.IdentityDb
{
    public static class UserProviderExpressions
    {
        public static Expression<Func<UserProvider, bool>> ProviderByAuthUIdFilter(string authUId)
            => PredicateBuilder.New<UserProvider>().And(up => up.Id == authUId);

        public static Expression<Func<UserProvider, bool>> ProvidersByUserIdentityIdFilter(Guid userIdentityId)
            => PredicateBuilder.New<UserProvider>().And(up => up.UserIdentityId == userIdentityId);
    }
}
