using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Infrastructure.Contracts.Question
{
    public interface IQuestionContract : IContract
    {
        public Guid QuestionId { get; set; }
        public string Description { get; }
        public IList<QuestionKeyFactViewModel> KeysFact { get; set; }
    }
}
