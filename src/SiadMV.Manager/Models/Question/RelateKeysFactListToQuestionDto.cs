using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.Question
{
    public class RelateKeysFactListToQuestionDto : IManagerContract
    {
        public Guid QuestionId { get; set; }
        public IList<Guid> KeysFactId { get; set; }
    }
}
