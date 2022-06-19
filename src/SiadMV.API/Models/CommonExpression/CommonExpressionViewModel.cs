using SiadMV.API.Infrastructure.Contracts.CommonExpression;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Models.CommonExpression
{
    public class CommonExpressionViewModel : ICommonExpressionContract, IResponse
    {
        public Guid CommonExpressionId { get; set; }
        public string Description { get; set; }
        public IList<CommonExpressionKeyFactViewModel> KeyFacts { get; set; }
    }
}
