using SiadMV.API.Models.CommonExpression;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.CommonExpression
{
    public class GetAllCommonExpressionsQuery : QueryEnumerableBase<IEnumerable<CommonExpressionViewModel>>
    {
    }
}
