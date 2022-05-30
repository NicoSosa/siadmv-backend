using SiadMV.API.Models;
using SiadMV.API.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Commands;


namespace SiadMV.API.Application.Commands.UserCase
{
    public class SearchKeysFactInUserCaseCommand : CommandBase<ResponseViewModel>
    {
        public string Description { get; set; }
    }
}
