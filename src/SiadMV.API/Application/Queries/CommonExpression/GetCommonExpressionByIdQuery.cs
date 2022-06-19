using SiadMV.API.Models.CommonExpression;
using SiadMV.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.CommonExpression
{
    public class GetCommonExpressionByIdQuery : QueryBase<CommonExpressionViewModel>
    {
        public Guid CommonExpressionId { get; }

        public GetCommonExpressionByIdQuery(Guid commonExpressionId)
        {
            CommonExpressionId = commonExpressionId;
        }
    }
}
