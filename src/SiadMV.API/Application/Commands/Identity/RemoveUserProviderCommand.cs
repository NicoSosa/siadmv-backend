using SiadMV.API.Models;
using SiadMV.ServiceBase.CQRS.Commands;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class RemoveUserProviderCommand: CommandBase<ResponseViewModel>
    {
        public string AuthUId { get; }

        public RemoveUserProviderCommand(string authUId)
        {
            AuthUId = authUId;
        }
    }
}
