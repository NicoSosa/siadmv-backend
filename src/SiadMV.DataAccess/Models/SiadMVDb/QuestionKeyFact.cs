using SiadMV.ServiceBase.DAL.Infrastructure.DataUnits;
using System;

namespace SiadMV.DataAccess.Models.SiadMVDb
{
    public class QuestionKeyFact : DataUnit<Guid>
    {
        public Guid KeyFactId { get; set; }
        public Guid QuestionId { get; set; }
        public KeyFact KeyFact { get; set; }
        public Question Question { get; set; }
    }
}
