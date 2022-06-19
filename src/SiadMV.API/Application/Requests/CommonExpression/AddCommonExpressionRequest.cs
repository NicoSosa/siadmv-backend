using MediatR;
using System.Collections.Generic;

namespace SiadMV.API.Application.Requests.CommonExpression
{
    public class AddCommonExpressionRequest : IRequest
    {
        public string Description { get; set; }
        public IList<CommonExpressionKeyFactForRequest> KeysFact { get; set; }
    }
}
