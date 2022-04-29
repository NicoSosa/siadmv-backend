using SiadMV.API.Models.Cart;
using EmpanadUS.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.Cart
{
    public class GetCartByUserIdentityIdQuery : QueryBase<CartViewModel>
    {
        public Guid UserIdentityId { get; }

        public GetCartByUserIdentityIdQuery(Guid userIdentityId)
        {
            UserIdentityId = userIdentityId;
        }
    }
}
