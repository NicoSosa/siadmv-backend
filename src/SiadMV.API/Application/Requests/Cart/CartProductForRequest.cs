using System;

namespace SiadMV.API.Application.Requests.Cart
{
    public class CartProductForRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
