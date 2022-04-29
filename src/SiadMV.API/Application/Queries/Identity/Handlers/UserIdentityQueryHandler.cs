using AutoMapper;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.Identity.Handlers
{
    public class UserIdentityQueryHandler :
        IQueryHandler<GetUserIdentityQuery, UserIdentityViewModel>
    {
        private readonly IUserIdentityService _userIdentityService;
        private readonly IMapper _mapper;

        public UserIdentityQueryHandler(
            IUserIdentityService userIdentityService,
            IMapper mapper)
        {
            _userIdentityService = userIdentityService;
            _mapper = mapper;
        }

        public async Task<UserIdentityViewModel> Handle(GetUserIdentityQuery request, CancellationToken cancellationToken)
        {
            var userIdentityDto = await _userIdentityService.GetUserIdentityByIdAsync(request.UserIdentityId);

            if (userIdentityDto == null)
            {
                Raise.Error.Generic<NotFoundException>(
                    ApiResources.MessagesResources.ErrorUserNotExists);
            }

            return _mapper.Map<UserIdentityViewModel>(userIdentityDto);
        }
    }
}
