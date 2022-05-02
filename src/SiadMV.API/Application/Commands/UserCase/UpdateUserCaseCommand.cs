using System;
using SiadMV.API.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.UserCase
{
    public class UpdateUserCaseCommand : CommandBase<UserCaseViewModel>
    {
        public Guid UserCaseId { get; set; }
        public string Description { get; set; }
    }
}
