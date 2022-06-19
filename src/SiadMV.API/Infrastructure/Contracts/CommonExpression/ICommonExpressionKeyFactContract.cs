using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Infrastructure.Contracts.CommonExpression
{
    public interface ICommonExpressionKeyFactContract : IContract
    {
        public Guid KeyFactId { get; }
        public Guid CommonExpressionId { get; }
        
    }
}
