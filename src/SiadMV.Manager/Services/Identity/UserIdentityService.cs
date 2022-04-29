using AutoMapper;
using SiadMV.DataAccess.Infrastructure.Queries.IdentityDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.Manager.Enums;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.Manager.Models.Identity;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services.Identity
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly IIdentityDbUoW _identityDBUoW;
        private readonly IUserIdentityQueryBuilder _userQueryBuilder;
        private readonly IMapper _mapper;

        public UserIdentityService(
            IIdentityDbUoW identityDBUoW,
            IUserIdentityQueryBuilder userQueryBuilder,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(identityDBUoW, nameof(identityDBUoW));
            Ensure.Parameter.IsNotNull(userQueryBuilder, nameof(userQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _identityDBUoW = identityDBUoW;
            _userQueryBuilder = userQueryBuilder;
            _mapper = mapper;
        }

        public async Task<UserIdentityDto> AddUserIdentityAsync(AddUserIdentityDto addUserDto)
        {
            await ValidateIfUserExistsAsync(addUserDto.Email);
            
            var userIdentity = _identityDBUoW.Add(_mapper.Map<UserIdentity>(addUserDto));

            if( addUserDto.Address != null) 
            { 
                var newUserAddress = _mapper.Map<UserAddress>(addUserDto.Address);
                newUserAddress.UserIdentityId = userIdentity.Id;
                newUserAddress.CreationDate = DateTime.UtcNow;
                var userAddress = _identityDBUoW.Add(newUserAddress);
            }

            var newUserProvider = _mapper.Map<UserProvider>(addUserDto.Provider);
            newUserProvider.UserIdentityId = userIdentity.Id;
            var userProvider = _identityDBUoW.Add(newUserProvider);

            await _identityDBUoW.CommitChangesAsync();
            return _mapper.Map<UserIdentityDto>(userIdentity);
        }

        public async Task<IEnumerable<UserIdentityDto>> GetUsersIdentitiesByEmailAsync(string email)
            => await _userQueryBuilder
                .Start()
                .FilterByEmail(email)
                .IncludeProviders()
                .IncludeAddresses()
                .QueryAsArrayAsync<UserIdentityDto>();

        public async Task<IEnumerable<UserIdentityDto>> GetUsersIdentitiesByUserProviderAsync(UserProviderValue userProvider)
            => await _userQueryBuilder
                .Start()
                .FilterByUserProvider(_mapper.Map<UserProviderValue, DataAccess.Enums.UserProviderValue>(userProvider))
                .IncludeProviders()
                .IncludeAddresses()
                .QueryAsArrayAsync<UserIdentityDto>();

        public async Task<UserIdentityDto> GetUserIdentityByIdAsync(Guid userId)
            => await _userQueryBuilder
                .Start()
                .FilterById(userId)
                .IncludeProviders()
                .IncludeAddresses()
                .GetRecordAsync<UserIdentityDto>();

        public async Task<UserIdentityDto> RemoveUserIdentityAsync(Guid userIdentityId)
        {
            var userDto = await GetUserIdentityByIdAsync(userIdentityId);
            _identityDBUoW.RemoveByIds<UserIdentity>(userIdentityId);
            await _identityDBUoW.CommitChangesAsync();

            return userDto;
        }
        public async Task<UserIdentityDto> UpdateUserIdentityAsync(UserIdentityDto userDto)
        {
            Ensure.Parameter.IsNotNull(userDto, nameof(userDto));

            var user = await _userQueryBuilder
                .Start()
                .FilterById(userDto.UserIdentityId)
                .GetRecordAsync(true);

            user.FirstName = userDto.FirstName;
            user.Surname = userDto.Surname;
            user.Phone = userDto.Phone;
            user.LastUpdateDate = DateTime.UtcNow;

            _identityDBUoW.Update(user);
            await _identityDBUoW.CommitChangesAsync();
            return _mapper.Map(user, userDto);
        }

        public async Task ValidateIfUserExistsAsync(string email)
        {
            var user = await _userQueryBuilder
                .Start()
                .FilterByEmail(email)
                .GetRecordAsync();

            if (user != null)
            {
                Raise.Error.Generic<NotFoundException>(ManagerResources.MessagesResources.ErrorUserAlreadyExists);
            }
        }

        public async Task ValidateIfUserExistsByIdAsync(Guid userIdentityId)
        {
            var userIdentity = await GetUserIdentityByIdAsync(userIdentityId);
            if (userIdentity == null)
            {
                Raise.Error.Generic<NotFoundException>(ManagerResources.MessagesResources.ErrorUserNotExist);
            }
        }
    }
}
