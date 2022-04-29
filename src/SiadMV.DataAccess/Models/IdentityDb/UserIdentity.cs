using SiadMV.DataAccess.Enums;
using SiadMV.ServiceBase.DAL.Infrastructure.DataUnits;
using System;
using System.Collections.Generic;

namespace SiadMV.DataAccess.Models.IdentityDb
{
    public class UserIdentity : AuditableDataUnit<Guid>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string CustomerSquareId { get; set; }

        public IList<UserProvider> Providers { get; set; }
        public IList<UserAddress> Addresses { get; set; }
    }
}

