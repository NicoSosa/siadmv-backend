using AutoMapper;
using SiadMV.DataAccess.Enums;
using SiadMV.DataAccess.Infrastructure.Queries.IdentityDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.Manager.Models.Identity;
using EmpanadUS.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services.Identity
{
    public class UserAddressService : IUserAddressService
    {
        private readonly IIdentityDbUoW _identityDBUoW;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUserAddressQueryBuilder _userAddressQueryBuilder;
        private readonly IMapper _mapper;

        public UserAddressService(
            IIdentityDbUoW identityDBUoW,
            IUserIdentityService userIdentityService,
            IUserAddressQueryBuilder userAddressQueryBuilder,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(identityDBUoW, nameof(identityDBUoW));
            Ensure.Parameter.IsNotNull(userAddressQueryBuilder, nameof(userAddressQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _identityDBUoW = identityDBUoW;
            _userIdentityService = userIdentityService;
            _userAddressQueryBuilder = userAddressQueryBuilder;
            _mapper = mapper;
        }

        public async Task<UserAddressDto> AddUserAddressAsync(AddUserAddressDto userAddressDto)
        {
            await _userIdentityService.ValidateIfUserExistsByIdAsync(userAddressDto.UserIdentityId);

            var userAddress = _identityDBUoW.Add(_mapper.Map<UserAddress>(userAddressDto));

            await _identityDBUoW.CommitChangesAsync();
            return _mapper.Map<UserAddressDto>(userAddress);
        }

        public async Task<IEnumerable<UserAddressDto>> GetAddressByUserIdentityIdAsync(Guid userIdentityId)
            => await _userAddressQueryBuilder
                .Start()
                .FilterByUserIdentityId(userIdentityId)
                .QueryAsArrayAsync<UserAddressDto>();

        public async Task<IEnumerable<UserAddressDto>> GetBillingAddressByUserIdentityIdAsync(Guid userIdentityId)
            => await _userAddressQueryBuilder
                .Start()
                //.FilterBillingAddressByUserIdentityId(userIdentityId)
                .QueryAsArrayAsync<UserAddressDto>();

        public async Task<IEnumerable<UserAddressDto>> GetAddressByZipcodeAsync(string zipcode)
            => await _userAddressQueryBuilder
                .Start()
                .FilterByZipcode(zipcode)
                .QueryAsArrayAsync<UserAddressDto>();
        public async Task<UserAddressDto> GetUserAddressByIdAsync(Guid userAddressId)
            => await _userAddressQueryBuilder
                .Start()
                .FilterById(userAddressId)
                .GetRecordAsync<UserAddressDto>();
        public async Task<UserAddressDto> RemoveUserAddressAsync(Guid userAddressId)
        {
            var userAddressDto = await GetUserAddressByIdAsync(userAddressId);

            if ( userAddressDto == null )
            {
                Raise.Error.Generic<NotFoundException>(ManagerResources.MessagesResources.ErrorUserAddressNotExists);
            }
            
            await ValidateLastAddressAsync(userAddressDto.UserIdentityId);

            _identityDBUoW.RemoveByIds<UserAddress>(userAddressId);
            await _identityDBUoW.CommitChangesAsync();

            return userAddressDto;
        }
        public async Task<UserAddressDto> UpdateUserAddressAsync(UserAddressDto userAddressDto)
        {
            Ensure.Parameter.IsNotNull(userAddressDto, nameof(userAddressDto));

            var userAddress = await _userAddressQueryBuilder
                .Start()
                .FilterById(userAddressDto.UserAddressId)
                .GetRecordAsync(true);

            userAddress.Address1 = userAddressDto.Address1;
            userAddress.Address2 = userAddressDto.Address2;
            userAddress.City = userAddressDto.City;
            userAddress.State = userAddressDto.State;
            userAddress.Zipcode = userAddressDto.Zipcode;
            //userAddress.AddressType = _mapper.Map<AddressType>(userAddressDto.AddressType);

            await _identityDBUoW.CommitChangesAsync();

            return _mapper.Map(userAddress, userAddressDto);        
        }

        private async Task ValidateLastAddressAsync(Guid userIdentityId)
        {
            var userAddress = await _userAddressQueryBuilder
                .Start()
                .FilterByUserIdentityId(userIdentityId)
                .QueryAsArrayAsync<UserAddressDto>();
            if (userAddress.Length <= 1 )
            {
                Raise.Error.Generic<ServiceValidationException>(ManagerResources.MessagesResources.ErrorLastUserAddress);
            }
        }
    }
}
