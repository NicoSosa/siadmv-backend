using SiadMV.API.Enums;
using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.Identity
{
    public class AddUserIdentityCommand : CommandBase<UserIdentityViewModel>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public UserAddressForCommand Address { get; set; }
        public UserProviderForCommand Provider { get; set; }
    }
}
