using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Infrastructure.Contracts.Cart
{
    public interface ICartProductContract : IContract
    {
        Guid CartProductId { get; }
        Guid CartId { get; }
        Guid ProductId { get; }
        int Quantity { get; }
        string Name { get; }
        string Description { get; }
    }
}
