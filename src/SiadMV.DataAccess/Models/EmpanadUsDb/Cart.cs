using SiadMV.DataAccess.Enums;
using SiadMV.ServiceBase.DAL.Infrastructure.DataUnits;
using System;
using System.Collections.Generic;

namespace SiadMV.DataAccess.Models.SiadMVDb
{
    public class Cart : AuditableDataUnit<Guid>
    {
        public Guid UserIdentityId { get; set; }
        public CartStatus Status { get; set; }
        public DateTime RefreshCartDate { get; set; }

        public IList<CartProduct> CartProducts { get; set; }
    }
}
