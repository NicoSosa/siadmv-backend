using AutoMapper;
using SiadMV.API.Models.UserCase;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Queries.UserCase.Handlers
{
    public class UserCasesListQueryHandler :
        IQueryEnumerableHandler<GetAllUserCaseQuery, IEnumerable<UserCaseViewModel>>
    {
        private readonly IUserCaseService _userCaseService;
        private readonly IMapper _mapper;

        public UserCasesListQueryHandler(
            IUserCaseService userCaseService,
            IMapper mapper)
        {
            _userCaseService = userCaseService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserCaseViewModel>> Handle(GetAllUserCaseQuery request, CancellationToken cancellationToken)
        {
            var userCasesDto = await _userCaseService.GetUserCasesAsync();
            return _mapper.Map<IEnumerable<UserCaseViewModel>>(userCasesDto);
        }
    }
}
