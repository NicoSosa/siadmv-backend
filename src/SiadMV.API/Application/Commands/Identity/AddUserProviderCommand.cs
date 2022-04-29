using SiadMV.API.Enums;
using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Commands;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class AddUserProviderCommand: CommandBase<UserProviderViewModel>
    {
        public string AuthUId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
        public Guid UserIdentityId { get; set; }
    }
}
