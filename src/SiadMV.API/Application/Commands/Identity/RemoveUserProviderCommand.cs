using SiadMV.API.Models;
using EmpanadUS.ServiceBase.CQRS.Commands;
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
