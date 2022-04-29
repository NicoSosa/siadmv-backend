using SiadMV.API.Enums;
using SiadMV.API.Infrastructure.Contracts.Identity;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Models.Identity
{
    public class UserProviderViewModel: IUserProviderContract, IResponse
    {
        public string AuthUId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
        public Guid UserIdentityId { get; set; }
    }
}
