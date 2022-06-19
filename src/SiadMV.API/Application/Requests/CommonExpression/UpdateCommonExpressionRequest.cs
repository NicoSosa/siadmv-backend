using MediatR;
using System;

namespace SiadMV.API.Application.Requests.CommonExpression
{
    public class UpdateCommonExpressionRequest : IRequest
    {
        public Guid CommonExpressionId { get; set; }
        public string Description { get; set; }
    }
}
