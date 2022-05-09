using SiadMV.API.Models.KeyFact;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Infrastructure.Contracts.KeyFact
{
    public interface IKeyFactContract : IContract
    {
        public Guid KeyFactId { get; set; }
        public string Description { get; set; }
        public IList<KeyFactQuestionViewModel> Questions { get; set; }
    }
}
