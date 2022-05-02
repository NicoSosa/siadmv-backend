using SiadMV.API.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.UserCase
{
    public class AddUserCaseCommand : CommandBase<UserCaseViewModel>
    {
        public string Description { get; set; }
    }
}
