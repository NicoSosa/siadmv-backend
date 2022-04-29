using SiadMV.API.Models;
using SiadMV.ServiceBase.CQRS.Commands;
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
