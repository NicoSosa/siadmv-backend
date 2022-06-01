using SiadMV.Manager.Models.CommonExpression;
using SiadMV.Manager.Models.Question;
using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.KeyFact
{
    public class KeyFactDto : IManagerResponse
    {
        public Guid KeyFactId { get; set; }
        public string Description { get; set; }
        public IList<QuestionKeyFactDto> Questions { get; set; }
        public IList<CommonExpressionKeyFactDto> CommonExpressions { get; set; }
    }
}
