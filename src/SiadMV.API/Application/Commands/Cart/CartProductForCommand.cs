using System;

namespace SiadMV.API.Application.Commands.Cart
{
    public class CartProductForCommand
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
