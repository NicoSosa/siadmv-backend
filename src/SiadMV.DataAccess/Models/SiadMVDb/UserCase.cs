using SiadMV.ServiceBase.DAL.Infrastructure.DataUnits;
using System;

namespace SiadMV.DataAccess.Models.SiadMVDb
{
    public class UserCase : AuditableDataUnit<Guid>
    {
        public string Description { get; set; }
    }
}
