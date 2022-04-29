using SiadMV.Manager.Enums;
using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.Identity
{
    public class AddUserProviderDto: IManagerContract
    {
        public string AuthUId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
        public Guid UserIdentityId { get; set; }
    }
}
