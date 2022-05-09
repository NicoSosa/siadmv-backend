using SiadMV.API.Infrastructure.Contracts.Question;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Models.Question
{
    public class QuestionViewModel : IQuestionContract, IResponse
    {
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
        public IList<QuestionKeyFactViewModel> KeysFact { get; set; }
    }
}
