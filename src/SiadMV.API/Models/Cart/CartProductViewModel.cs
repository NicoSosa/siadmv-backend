using SiadMV.API.Infrastructure.Contracts.Cart;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Models.Cart
{
    public class CartProductViewModel : ICartProductContract, IResponse
    {
        public Guid CartProductId { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
