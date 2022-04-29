using SiadMV.Manager.Models.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services.Identity
{
    public interface IUserProviderService
    {
        Task<UserProviderDto> AddUserProviderAsync(AddUserProviderDto userProviderDto);
        Task<UserProviderDto> GetUserProviderByAuthUIdAsync(string authUId);
        Task<IEnumerable<UserProviderDto>> GetUserProvidersByUserIdentityIdAsync(Guid userIdentityId);
        Task<UserProviderDto> RemoveUserProviderAsync(string authUId);
    }
}
