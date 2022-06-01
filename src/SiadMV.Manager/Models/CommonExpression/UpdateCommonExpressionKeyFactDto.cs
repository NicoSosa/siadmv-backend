using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.CommonExpression
{
    public class UpdateCommonExpressionKeyFactDto : IManagerContract
    {
        public Guid CommonExpressionId { get; set; }
        public IList<CommonExpressionKeyFactDto> KeysFact { get; set; }
    }
}
