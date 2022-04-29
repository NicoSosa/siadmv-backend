using SiadMV.DataAccess.Enums;
using EmpanadUS.ServiceBase.DAL.Infrastructure.DataUnits;
using System;

namespace SiadMV.DataAccess.Models.IdentityDb
{
    public class UserProvider: DataUnit<string>
    {
        public Guid UserIdentityId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
        public UserIdentity UserIdentity { get; set; }
    }
}
