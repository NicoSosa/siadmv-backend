using AutoMapper;
using SiadMV.API.Enums;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.Identity.Handlers
{
    public class UsersIdentitiesListQueryHandler : 
        IQueryEnumerableHandler<GetUsersIdentitiesByEmail, IEnumerable<UserIdentityViewModel>>,
        IQueryEnumerableHandler<GetUsersIdentitiesByUserProvider, IEnumerable<UserIdentityViewModel>>
    {
        private readonly IUserIdentityService _userIdentityService;
        private readonly IMapper _mapper;

        public UsersIdentitiesListQueryHandler(
            IUserIdentityService userIdentityService,
            IMapper mapper)
        {
            _userIdentityService = userIdentityService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserIdentityViewModel>> Handle(GetUsersIdentitiesByEmail request, CancellationToken cancellationToken)
        {
            var usersIdentities = await _userIdentityService.GetUsersIdentitiesByEmailAsync(request.Email);
            if (usersIdentities == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserNotExists);
            }
            return _mapper.Map<IEnumerable<UserIdentityViewModel>>(usersIdentities);
        }

        public async Task<IEnumerable<UserIdentityViewModel>> Handle(GetUsersIdentitiesByUserProvider request, CancellationToken cancellationToken)
        {
            var usersIdentities = await _userIdentityService.GetUsersIdentitiesByUserProviderAsync(_mapper.Map<UserProviderValue, Manager.Enums.UserProviderValue>(request.UserProvider));
            if (usersIdentities == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserNotExists);
            }
            return _mapper.Map<IEnumerable<UserIdentityViewModel>>(usersIdentities);
        }

    }
}
