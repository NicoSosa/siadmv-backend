using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;

namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class CartProductQueryBuilder : SiadMVDbQueryBuilder<CartProduct, ICartProductQueryBuilder>, ICartProductQueryBuilder
    {
        public CartProductQueryBuilder(SiadMVDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
        public ICartProductQueryBuilder FilterByCartIdAsync(Guid cartId)
            => FilterBy(CartProductExpressions.CartProductByCartIdFilter(cartId));
    }
}
