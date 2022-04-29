using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.DataAccess.Enums;
using LinqKit;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace SiadMV.DataAccess.Expressions.IdentityDb
{
    public static class UserIdentityExpressions
    {
        public static Expression<Func<UserIdentity, bool>> EmailFilter(string email)
            => PredicateBuilder.New<UserIdentity>().And(ui => ui.Email == email);

        public static Expression<Func<UserIdentity, bool>> UserIdentityIdFilter(Guid userIdentityId)
            => PredicateBuilder.New<UserIdentity>().And(ui => ui.Id == userIdentityId);

        public static Expression<Func<UserIdentity, bool>> UsersByProviderFilter(UserProviderValue userProvider)
            => PredicateBuilder.New<UserIdentity>().And(ui => ui.Providers.Any(p => p.UserProviderValue == userProvider));
    }
}
