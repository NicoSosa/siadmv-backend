using System.Collections.Generic;
using SiadMV.API.Models.CommonExpression;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.CommonExpression
{
    public class AddCommonExpressionCommand : CommandBase<CommonExpressionViewModel>
    {
        public string Description { get; set; }
        public IList<CommonExpressionKeyFactForCommand> KeysFact { get; set; }
    }
}
