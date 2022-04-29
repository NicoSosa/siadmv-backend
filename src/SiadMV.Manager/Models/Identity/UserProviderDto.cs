using SiadMV.Manager.SeedWork;
using SiadMV.Manager.Enums;
using System;

namespace SiadMV.Manager.Models.Identity
{
    public class UserProviderDto: IManagerContract, IManagerResponse 
    {
        public string AuthUId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
        public Guid UserIdentityId { get; set; }
    }
}
