using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;

namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class CartQueryBuilder : SiadMVDbQueryBuilder<Cart, ICartQueryBuilder>, ICartQueryBuilder
    {
        public CartQueryBuilder(SiadMVDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public ICartQueryBuilder FilterById(Guid cartId)
            => FilterBy(CartExpressions.CartIdFilter(cartId));
        public ICartQueryBuilder FilterByUserIdentityId(Guid userIdentityId)
            => FilterBy(CartExpressions.UserIdentityIdFilter(userIdentityId));
        public ICartQueryBuilder IncludeCartProducts()
            => Include(c => c.CartProducts);
    }
}
