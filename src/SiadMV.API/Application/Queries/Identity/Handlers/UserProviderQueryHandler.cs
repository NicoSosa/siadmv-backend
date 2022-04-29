using AutoMapper;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Infrastructure.Services.Identity;
using EmpanadUS.ServiceBase.CQRS.Queries;
using EmpanadUS.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.Identity.Handlers
{
    public class UserProviderQueryHandler:
        IQueryHandler<GetUserProviderQuery, UserProviderViewModel>
    {
        private readonly IUserProviderService _userProviderService;
        private readonly IMapper _mapper;

        public UserProviderQueryHandler(
            IUserProviderService userProviderService,
            IMapper mapper)
        {
            _userProviderService = userProviderService;
            _mapper = mapper;
        }

        public async Task<UserProviderViewModel> Handle(GetUserProviderQuery request, CancellationToken cancellationToken)
        {
            var userProviderDto = await _userProviderService.GetUserProviderByAuthUIdAsync(request.AuthUId);
            if (userProviderDto == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserProviderNotExists);
            }

            return _mapper.Map<UserProviderViewModel>(userProviderDto);
        }
    }
}
