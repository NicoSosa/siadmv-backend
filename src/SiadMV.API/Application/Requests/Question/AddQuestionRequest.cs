using MediatR;
using System.Collections.Generic;

namespace SiadMV.API.Application.Requests.Question
{
    public class AddQuestionRequest : IRequest
    {
        public string Description { get; set; }
        public IList<QuestionKeyFactForRequest> KeysFact { get; set; }
    }
}
