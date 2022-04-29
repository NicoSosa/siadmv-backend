using AutoMapper;
using SiadMV.API.Models;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.Manager.Models.Identity;
using SiadMV.ServiceBase.CQRS.Commands;
using MGK.Extensions;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Commands.Identity.Handlers
{
    public class UserProviderCommandHandler: 
        ICommandHandler<AddUserProviderCommand, UserProviderViewModel>,
        ICommandHandler<RemoveUserProviderCommand, ResponseViewModel>
    {
        private readonly IUserProviderService _userProviderService;
        private readonly IMapper _mapper;

        public UserProviderCommandHandler(
            IUserProviderService userProviderService,
            IMapper mapper)
        {
            _userProviderService = userProviderService;
            _mapper = mapper;
        }

        public async Task<UserProviderViewModel> Handle(AddUserProviderCommand request, CancellationToken cancellationToken)
        {
            var addUserProviderDto = _mapper.Map<AddUserProviderDto>(request);
            var userProviderDto = await _userProviderService.AddUserProviderAsync(addUserProviderDto);

            return _mapper.Map<UserProviderViewModel>(userProviderDto);
        }

        public async Task<ResponseViewModel> Handle(RemoveUserProviderCommand request, CancellationToken cancellationToken)
        {
            var userProviderDto = await _userProviderService.RemoveUserProviderAsync(request.AuthUId);

            return new ResponseViewModel
            {
                Message = ApiResources.MessagesResources.InformationRemoveUserProvider,
                Data = _mapper.Map<UserProviderViewModel>(userProviderDto)
            };
        }
    }
}
