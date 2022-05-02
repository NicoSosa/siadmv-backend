using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;


namespace SiadMV.Manager.Models.Question
{
    public class UpdateQuestionKeyFactDto : IManagerContract
    {
        public Guid QuestionId { get; set; }
        public IList<QuestionKeyFactDto> KeysFact { get; set; }
    }
}
