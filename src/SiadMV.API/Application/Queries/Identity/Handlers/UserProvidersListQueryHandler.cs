using AutoMapper;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Infrastructure.Services.Identity;
using EmpanadUS.ServiceBase.CQRS.Queries;
using EmpanadUS.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Queries.Identity.Handlers
{
    public class UserProvidersListQueryHandler:
        IQueryEnumerableHandler<GetUserProvidersByUserIdentityIdQuery, IEnumerable<UserProviderViewModel>>
    {
        private readonly IUserProviderService _userProviderService;
        private readonly IMapper _mapper;

        public UserProvidersListQueryHandler(
            IUserProviderService userProviderService,
            IMapper mapper)
        {
            _userProviderService = userProviderService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserProviderViewModel>> Handle(GetUserProvidersByUserIdentityIdQuery request, CancellationToken cancellationToken)
        {
            var userProviders = await _userProviderService.GetUserProvidersByUserIdentityIdAsync(request.UserIdentityId);
            if (userProviders == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserProviderNotExists);
            }

            return _mapper.Map<IEnumerable<UserProviderViewModel>>(userProviders);
        }
    }
}
