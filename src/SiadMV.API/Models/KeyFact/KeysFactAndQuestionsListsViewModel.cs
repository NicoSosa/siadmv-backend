using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System.Collections.Generic;

namespace SiadMV.API.Models.KeyFact
{
    public class KeysFactAndQuestionsListsViewModel : IResponse
    {
        public IList<KeyFactViewModel> KeysFact { get; set; }
        public IList<QuestionViewModel> Questions { get; set; }
    }
}
