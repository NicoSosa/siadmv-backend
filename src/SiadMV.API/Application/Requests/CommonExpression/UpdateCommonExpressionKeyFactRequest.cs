using MediatR;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Application.Requests.CommonExpression
{
    public class UpdateCommonExpressionKeyFactRequest : IRequest
    {
        public Guid CommonExpressionId { get; set; }
        public IList<CommonExpressionKeyFactForRequest> KeysFact { get; set; }
    }
}
