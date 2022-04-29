using SiadMV.API.Enums;
using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Commands;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class UpdateUserIdentityCommand : CommandBase<UserIdentityViewModel>
    {
        public Guid UserIdentityId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
