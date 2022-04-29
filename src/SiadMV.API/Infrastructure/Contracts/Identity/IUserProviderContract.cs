using SiadMV.API.Enums;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiadMV.API.Infrastructure.Contracts.Identity
{
    public interface IUserProviderContract: IContract
    {
        UserProviderValue UserProviderValue { get; }
        Guid UserIdentityId { get; }
    }
}
