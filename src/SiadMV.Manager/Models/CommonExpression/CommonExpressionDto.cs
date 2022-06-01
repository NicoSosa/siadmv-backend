using SiadMV.Manager.Models.KeyFact;
using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;


namespace SiadMV.Manager.Models.CommonExpression
{
    public class CommonExpressionDto : IManagerResponse
    { 
        public Guid CommonExpressionId { get; set; }
        public string Description { get; set; }
        public IList<CommonExpressionKeyFactDto> KeysFact { get; set; }
    }
}
