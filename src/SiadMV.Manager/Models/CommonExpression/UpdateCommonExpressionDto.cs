using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.CommonExpression
{
    public class UpdateCommonExpressionDto : IManagerContract
    {
        public Guid CommonExpressionId { get; set; }
        public string Description { get; set; }
    }
}
