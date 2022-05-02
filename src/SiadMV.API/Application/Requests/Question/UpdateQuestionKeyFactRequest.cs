using MediatR;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Application.Requests.Question
{
    public class UpdateQuestionKeyFactRequest : IRequest
    {
        public Guid QuestionId { get; set; }
        public IList<QuestionKeyFactForRequest> KeysFact { get; set; }
    }
}
