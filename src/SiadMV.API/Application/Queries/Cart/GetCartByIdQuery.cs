using SiadMV.API.Models.Cart;
using SiadMV.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.Cart
{
    public class GetCartByIdQuery : QueryBase<CartViewModel>
    {
        public Guid CartId { get; }

        public GetCartByIdQuery(Guid cartId)
        {
            CartId = cartId;
        }
    }
}
