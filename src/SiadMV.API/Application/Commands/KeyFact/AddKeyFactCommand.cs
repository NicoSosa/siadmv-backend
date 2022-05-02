using SiadMV.API.Models.KeyFact;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.KeyFact
{
    public class AddKeyFactCommand : CommandBase<KeyFactViewModel>
    {
        public string Description { get; set; }
    }
}
