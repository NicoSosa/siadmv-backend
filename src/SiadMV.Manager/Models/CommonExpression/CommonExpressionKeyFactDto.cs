using SiadMV.Manager.Models.KeyFact;
using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.CommonExpression
{
    public class CommonExpressionKeyFactDto : IManagerContract
    {
        public Guid KeyFactId { get; set; }
        public Guid CommonExpressionId { get; set; }
        public KeyFactDto KeyFact { get; set; }
        public CommonExpressionDto CommonExpression { get; set; }
    }
}
