using SiadMV.Manager.Enums;
using SiadMV.Manager.Models.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services.Identity
{
    public interface IUserIdentityService
    {
        Task<UserIdentityDto> AddUserIdentityAsync(AddUserIdentityDto userDto);
        Task<IEnumerable<UserIdentityDto>> GetUsersIdentitiesByEmailAsync(string email);
        Task<IEnumerable<UserIdentityDto>> GetUsersIdentitiesByUserProviderAsync(UserProviderValue userProvider);
        Task<UserIdentityDto> GetUserIdentityByIdAsync(Guid userId);
        Task<UserIdentityDto> RemoveUserIdentityAsync(Guid userId);
        Task<UserIdentityDto> UpdateUserIdentityAsync(UserIdentityDto userDto);

        Task ValidateIfUserExistsAsync(string email);
        Task ValidateIfUserExistsByIdAsync(Guid userIdentityId);
    }
}
