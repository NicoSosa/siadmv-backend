using System;
using SiadMV.API.Models.KeyFact;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.KeyFact
{
    public class UpdateKeyFactCommand : CommandBase<KeyFactViewModel>
    {
        public Guid KeyFactId { get; set; }
        public string Description { get; set; }
    }
}
