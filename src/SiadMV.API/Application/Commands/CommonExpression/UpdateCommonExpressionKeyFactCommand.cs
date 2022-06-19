using System;
using System.Collections.Generic;
using SiadMV.API.Models.CommonExpression;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.CommonExpression
{
    public class UpdateCommonExpressionKeyFactCommand : CommandBase<CommonExpressionViewModel>
    {
        public Guid CommonExpressionId { get; set; }
        public IList<CommonExpressionKeyFactForCommand> KeysFact { get; set; }
    }
}
