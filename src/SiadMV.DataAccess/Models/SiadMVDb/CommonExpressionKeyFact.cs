using SiadMV.ServiceBase.DAL.Infrastructure.DataUnits;
using System;

namespace SiadMV.DataAccess.Models.SiadMVDb
{
    public class CommonExpressionKeyFact : DataUnit<Guid>
    {
        public Guid KeyFactId { get; set; }
        public Guid CommonExpressionId { get; set; }
        public KeyFact KeyFact { get; set; }
        public CommonExpression CommonExpression { get; set; }
    }
}
