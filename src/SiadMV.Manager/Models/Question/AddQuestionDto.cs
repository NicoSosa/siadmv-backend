using SiadMV.Manager.SeedWork;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.Question
{
    public class AddQuestionDto : IManagerContract
    {
        public string Description { get; set; }
        public IList<QuestionKeyFactDto> KeysFact { get; set; }
    }
}
