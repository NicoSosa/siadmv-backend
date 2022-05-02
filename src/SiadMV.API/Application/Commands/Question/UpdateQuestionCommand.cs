using System;
using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.Question
{
    public class UpdateQuestionCommand : CommandBase<QuestionViewModel>
    {
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
    }
}
