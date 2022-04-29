using SiadMV.API.Enums;
using SiadMV.API.Infrastructure.Contracts.Cart;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Models.Cart
{
    public class CartViewModel : ICartContract, IResponse
    {
        public Guid CartId { get; set; }
        public Guid UserIdentityId { get; set; }
        public CartStatus Status { get; set; }
        public DateTime RefreshCartDate { get; set; }
        public IList<CartProductViewModel> CartProducts { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal Price { get; set; }
    }
}
