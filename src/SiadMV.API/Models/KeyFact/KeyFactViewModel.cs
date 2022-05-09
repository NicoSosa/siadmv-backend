using SiadMV.API.Infrastructure.Contracts.KeyFact;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Models.KeyFact
{
    public class KeyFactViewModel : IKeyFactContract, IResponse
    {
        public Guid KeyFactId { get; set; }
        public string Description { get; set; }
        public IList<KeyFactQuestionViewModel> Questions { get; set; }
    }
}
