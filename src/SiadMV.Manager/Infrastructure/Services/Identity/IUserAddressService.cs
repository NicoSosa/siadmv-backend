using SiadMV.Manager.Models.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services.Identity
{
    public interface IUserAddressService
    {
        Task<UserAddressDto> AddUserAddressAsync(AddUserAddressDto userAddressDto);
        Task<IEnumerable<UserAddressDto>> GetAddressByUserIdentityIdAsync(Guid userIdentityId);
        Task<IEnumerable<UserAddressDto>> GetAddressByZipcodeAsync(string zipcode);
        Task<UserAddressDto> GetUserAddressByIdAsync(Guid userAddressId);
        Task<UserAddressDto> RemoveUserAddressAsync(Guid userAddressId);
        Task<UserAddressDto> UpdateUserAddressAsync(UserAddressDto userAddressDto);
    }
}
 