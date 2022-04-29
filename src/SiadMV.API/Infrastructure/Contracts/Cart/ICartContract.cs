using SiadMV.API.Enums;
using SiadMV.API.Models.Cart;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Infrastructure.Contracts.Cart
{
    public interface ICartContract : IContract
    {
        Guid CartId { get; }
        Guid UserIdentityId { get; }
        CartStatus Status { get; }
        DateTime RefreshCartDate { get; }
        IList<CartProductViewModel> CartProducts { get; }
        DateTime CreationDate { get; }
        DateTime? LastUpdateDate { get; }
    }
}
