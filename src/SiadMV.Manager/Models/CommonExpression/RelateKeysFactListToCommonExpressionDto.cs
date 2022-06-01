using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.CommonExpression
{
    public class RelateKeysFactListToCommonExpressionDto : IManagerContract
    {
        public Guid CommonExpressionId { get; set; }
        public IList<Guid> KeysFactId { get; set; }
    }
}
