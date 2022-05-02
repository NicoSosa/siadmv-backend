using SiadMV.Manager.Models.KeyFact;
using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.Question
{
    public class QuestionDto : IManagerResponse
    {
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
        public IList<QuestionKeyFactDto> KeysFact { get; set; }
    }
}
