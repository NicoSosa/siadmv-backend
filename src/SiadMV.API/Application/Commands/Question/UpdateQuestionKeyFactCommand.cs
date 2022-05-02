using System;
using System.Collections.Generic;
using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.Question
{
    public class UpdateQuestionKeyFactCommand : CommandBase<QuestionViewModel>
    {
        public Guid QuestionId { get; set; }
        public IList<QuestionKeyFactForCommand> KeysFact { get; set; }
    }
}
