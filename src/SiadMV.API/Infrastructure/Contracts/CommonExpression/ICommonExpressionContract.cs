using SiadMV.API.Models.CommonExpression;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Infrastructure.Contracts.CommonExpression
{
    public interface ICommonExpressionContract : IContract
    {
        public Guid CommonExpressionId { get; set; }
        public string Description { get; }
        public IList<CommonExpressionKeyFactViewModel> KeyFacts { get; set; }
    }
}
