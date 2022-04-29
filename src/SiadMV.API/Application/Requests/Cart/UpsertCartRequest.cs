using SiadMV.API.Enums;
using MediatR;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Application.Requests.Cart
{
    public class UpsertCartRequest : IRequest
    {
        public Guid UserIdentityId { get; set; }
        public CartStatus Status { get; set; }
        public DateTime RefreshCartDate { get; set; }
        public IList<CartProductForRequest> CartProducts { get; set; }
    }
}
