using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public static class CartProductExpressions
    {
        public static Expression<Func<CartProduct, bool>> CartProductByCartIdFilter(Guid cartId)
            => PredicateBuilder.New<CartProduct>().And(cp => cp.CartId == cartId);
    }
}
