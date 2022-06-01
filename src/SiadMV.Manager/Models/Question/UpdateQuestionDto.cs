using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.Question
{
    public class UpdateQuestionDto : IManagerContract
    {
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
    }
}
