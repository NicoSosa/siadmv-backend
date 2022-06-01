﻿using SiadMV.ServiceBase.DAL.Infrastructure.DataUnits;
using System;
using System.Collections.Generic;

namespace SiadMV.DataAccess.Models.SiadMVDb
{
    public class KeyFact : AuditableDataUnit<Guid>
    {
        public string Description { get; set; }
        public IList<QuestionKeyFact> Questions { get; set; }
        public IList<CommonExpressionKeyFact> CommonExpressions { get; set; }
    }
}
