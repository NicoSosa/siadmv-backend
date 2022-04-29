using SiadMV.API.Models;
using EmpanadUS.ServiceBase.CQRS.Commands;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class RemoveUserAddressCommand : CommandBase<ResponseViewModel>
    {
        public Guid UserAddressId { get; }

        public RemoveUserAddressCommand(Guid userAddressId)
        {
            UserAddressId = userAddressId;
        }
    }
}
