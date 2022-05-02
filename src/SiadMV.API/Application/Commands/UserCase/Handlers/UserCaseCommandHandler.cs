using AutoMapper;
using SiadMV.API.Models.UserCase;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Commands.UserCase.Handlers
{
    public class UserCaseCommandHandler :
        ICommandHandler<AddUserCaseCommand, UserCaseViewModel>,
        ICommandHandler<UpdateUserCaseCommand, UserCaseViewModel>
    {
        private readonly IUserCaseService _userCaseService;
        private readonly IMapper _mapper;
        public UserCaseCommandHandler(
            IUserCaseService userCaseService,
            IMapper mapper)
        {
            _userCaseService = userCaseService;
            _mapper = mapper;
        }

        public async Task<UserCaseViewModel> Handle(AddUserCaseCommand request, CancellationToken cancellationToken)
        {
            var addUserCaseDto = _mapper.Map<AddUserCaseDto>(request);
            var UserCaseDto = await _userCaseService.CreateUserCaseAsync(addUserCaseDto);

            return _mapper.Map<UserCaseViewModel>(UserCaseDto);
        }

        public async Task<UserCaseViewModel> Handle(UpdateUserCaseCommand request, CancellationToken cancellationToken)
        {
            var updateUserCaseDto = _mapper.Map<UpdateUserCaseDto>(request);
            var UserCaseDto = await _userCaseService.UpdateUserCaseAsync(updateUserCaseDto);

            return _mapper.Map<UserCaseViewModel>(UserCaseDto);
        }
    }
}
