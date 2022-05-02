using AutoMapper;
using SiadMV.API.Models.UserCase;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Queries.UserCase.Handlers
{
    public class UserCaseQueryHandler : 
        IQueryHandler<GetUserCaseByIdQuery, UserCaseViewModel>,
        IQueryHandler<GetRandomUserCaseQuery, UserCaseViewModel>
    {
        private readonly IUserCaseService _userCaseService;
        private readonly IMapper _mapper;
        public UserCaseQueryHandler(
            IUserCaseService userCaseService,
            IMapper mapper)
        {
            _userCaseService = userCaseService;
            _mapper = mapper;
        }

        public async Task<UserCaseViewModel> Handle(GetUserCaseByIdQuery request, CancellationToken cancellationToken)
        {
            var userCaseDto = await _userCaseService.GetUserCaseByIdAsync(request.UserCaseId);

            if (userCaseDto == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserCaseNotExists);
            }
            return _mapper.Map<UserCaseViewModel>(userCaseDto);
        }

        public async Task<UserCaseViewModel> Handle(GetRandomUserCaseQuery request, CancellationToken cancellationToken)
        {
            var userCaseDto = await _userCaseService.GetRandomUserCaseAsync();

            if (userCaseDto == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserCaseNotExists);
            }
            return _mapper.Map<UserCaseViewModel>(userCaseDto);
        }
    }
}
