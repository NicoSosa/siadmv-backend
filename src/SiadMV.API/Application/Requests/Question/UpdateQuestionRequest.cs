using MediatR;
using System;

namespace SiadMV.API.Application.Requests.Question
{
    public class UpdateQuestionRequest : IRequest
    {
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
    }
}
