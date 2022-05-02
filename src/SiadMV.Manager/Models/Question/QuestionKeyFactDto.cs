using SiadMV.Manager.Models.KeyFact;
using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.Question
{
    public class QuestionKeyFactDto : IManagerContract
    {
        public Guid KeyFactId { get; set; }
        public Guid QuestionId { get; set; }
        public KeyFactDto KeyFact { get; set; }
        public QuestionDto Question { get; set; }
    }
}
