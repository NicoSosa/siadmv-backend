using SiadMV.API.Enums;
using SiadMV.API.Models.Cart;
using EmpanadUS.ServiceBase.CQRS.Commands;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Application.Commands.Cart
{
    public class UpsertCartCommand : CommandBase<CartViewModel>
    {
        public Guid UserIdentityId { get; set; }
        public CartStatus Status { get; set; }
        public DateTime RefreshCartDate { get; set; }
        public IList<CartProductForCommand> CartProducts { get; set; }
    }
}
