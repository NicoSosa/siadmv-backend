using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.Cart
{
    public class CartProductDto : IManagerContract, IManagerResponse
    {
        public Guid CartProductId { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
