using SiadMV.Manager.Enums;
using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.Cart
{
    public class UpsertCartDto : IManagerContract
    {
        public Guid UserIdentityId { get; set; }
        public CartStatus Status { get; set; }
        public DateTime RefreshCartDate { get; set; }
        public IList<CartProductDto> CartProducts { get; set; }
    }
}
