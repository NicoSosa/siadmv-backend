using SiadMV.Manager.SeedWork;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.CommonExpression
{
    public class AddCommonExpressionDto : IManagerContract
    {
        public string Description { get; set; }
        public IList<CommonExpressionKeyFactDto> KeysFact { get; set; }
    }
}
