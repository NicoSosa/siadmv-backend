using SiadMV.Manager.Enums;
using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.Cart
{
    public class CartDto : IManagerContract, IManagerResponse
    {
        public Guid CartId { get; set; }
        public Guid UserIdentityId { get; set; }
        public CartStatus Status { get; set; }
        public DateTime UpdateCartDate { get; set; }
        public IList<CartProductDto> CartProducts { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal Price { get; set; }
    }
}
