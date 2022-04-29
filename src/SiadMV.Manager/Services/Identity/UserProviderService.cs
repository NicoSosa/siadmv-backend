using AutoMapper;
using SiadMV.DataAccess.Infrastructure.Queries.IdentityDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.Manager.Enums;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.Manager.Models.Identity;
using EmpanadUS.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services.Identity
{
    public class UserProviderService: IUserProviderService
    {
        private readonly IIdentityDbUoW _identityDBUoW;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUserProviderQueryBuilder _userProviderQueryBuilder;
        private readonly IMapper _mapper;

        public UserProviderService(
            IIdentityDbUoW identityDBUoW,
            IUserProviderQueryBuilder userProviderQueryBuilder,
            IUserIdentityService userIdentityService,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(identityDBUoW, nameof(identityDBUoW));
            Ensure.Parameter.IsNotNull(userProviderQueryBuilder, nameof(userProviderQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _identityDBUoW = identityDBUoW;
            _userIdentityService = userIdentityService;
            _userProviderQueryBuilder = userProviderQueryBuilder;
            _mapper = mapper;

        }
        public async Task<UserProviderDto> AddUserProviderAsync(AddUserProviderDto userProviderDto)
        {
            await _userIdentityService.ValidateIfUserExistsByIdAsync(userProviderDto.UserIdentityId);

            var userProvider = _identityDBUoW.Add(_mapper.Map<UserProvider>(userProviderDto));

            await _identityDBUoW.CommitChangesAsync();
            return _mapper.Map<UserProviderDto>(userProvider);
        }

        public async Task<UserProviderDto> GetUserProviderByAuthUIdAsync(string authUId)
            => await _userProviderQueryBuilder
                .Start()
                .FilterByAuthUId(authUId)
                .GetRecordAsync<UserProviderDto>();

        public async Task<IEnumerable<UserProviderDto>> GetUserProvidersByUserIdentityIdAsync(Guid userIdentityId)
            => await _userProviderQueryBuilder
                .Start()
                .FilterByUserIdentityId(userIdentityId)
                .QueryAsArrayAsync<UserProviderDto>();

        public async Task<UserProviderDto> RemoveUserProviderAsync(string authUId)
        {
            var userProviderDto = await GetUserProviderByAuthUIdAsync(authUId);

            if (userProviderDto == null) 
            {
                Raise.Error.Generic<NotFoundException>(ManagerResources.MessagesResources.ErrorUserProviderNotExist);
            }

            await ValidateLastProviderAsync(userProviderDto.UserIdentityId);

            _identityDBUoW.RemoveByIds<UserProvider>(authUId);
            await _identityDBUoW.CommitChangesAsync();

            return userProviderDto;
        }

        private async Task ValidateLastProviderAsync(Guid userIdentityId)
        {
            var userProvider = await _userProviderQueryBuilder
                .Start()
                .FilterByUserIdentityId(userIdentityId)
                .QueryAsArrayAsync<UserProviderDto>();
            if (userProvider.Length <= 1)
            {
                Raise.Error.Generic<InvalidRequestException>(ManagerResources.MessagesResources.ErrorLastUserProvider);
            }

        }
    }
}
