using System;
using SiadMV.API.Models.CommonExpression;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.CommonExpression
{
    public class UpdateCommonExpressionCommand : CommandBase<CommonExpressionViewModel>
    {
        public Guid CommonExpressionId { get; set; }
        public string Description { get; set; }
    }
}
