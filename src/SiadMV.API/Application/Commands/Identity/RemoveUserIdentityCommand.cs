using SiadMV.API.Models;
using EmpanadUS.ServiceBase.CQRS.Commands;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class RemoveUserIdentityCommand : CommandBase<ResponseViewModel>
    {
        public Guid UserIdentityId { get; }

        public RemoveUserIdentityCommand(Guid userIdentityId)
        {
            UserIdentityId = userIdentityId;
        }
    }
}
