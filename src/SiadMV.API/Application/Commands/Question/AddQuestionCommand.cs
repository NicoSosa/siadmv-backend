using System.Collections.Generic;
using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.Question
{
    public class AddQuestionCommand : CommandBase<QuestionViewModel>
    {
        public string Description { get; set; }
        public IList<QuestionKeyFactForCommand> KeysFact { get; set; }
    }
}
