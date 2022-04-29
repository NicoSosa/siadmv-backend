using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public static class CartExpressions
    {
        public static Expression<Func<Cart, bool>> CartIdFilter(Guid cartId)
            => PredicateBuilder.New<Cart>().And(c => c.Id == cartId);

        public static Expression<Func<Cart, bool>> UserIdentityIdFilter(Guid userIdentityId)
            => PredicateBuilder.New<Cart>().And(c => c.UserIdentityId == userIdentityId);
    }
}
