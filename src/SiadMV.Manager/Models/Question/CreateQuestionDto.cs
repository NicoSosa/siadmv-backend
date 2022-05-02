using SiadMV.Manager.SeedWork;

namespace SiadMV.Manager.Models.Question
{
    public class CreateQuestionDto : IManagerContract
    {
        public string Description { get; set; }
    }
}
