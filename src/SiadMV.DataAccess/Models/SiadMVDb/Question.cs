using SiadMV.ServiceBase.DAL.Infrastructure.DataUnits;
using System;
using System.Collections.Generic;

namespace SiadMV.DataAccess.Models.SiadMVDb
{
    public class Question : AuditableDataUnit<Guid>
    {
        public string Description { get; set; }
        public IList<QuestionKeyFact> KeysFact { get; set; }
    }
}
