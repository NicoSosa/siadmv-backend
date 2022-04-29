using SiadMV.DataAccess.Enums;
using EmpanadUS.ServiceBase.DAL.Infrastructure.DataUnits;
using System;

namespace SiadMV.DataAccess.Models.IdentityDb
{
    public class UserAddress : AuditableDataUnit<Guid>
    {
        public Guid UserIdentityId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string AddressType { get; set; }

        public UserIdentity UserIdentity { get; set; }
    }
}