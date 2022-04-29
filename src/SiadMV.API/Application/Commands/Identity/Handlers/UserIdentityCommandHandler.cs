using AutoMapper;
using SiadMV.API.Models;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.Manager.Models.Identity;
using EmpanadUS.ServiceBase.CQRS.Commands;
using MGK.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Commands.Identity.Handlers
{
    public class UserIdentityCommandHandler :
        ICommandHandler<AddUserIdentityCommand, UserIdentityViewModel>,
        ICommandHandler<RemoveUserIdentityCommand, ResponseViewModel>,
        ICommandHandler<UpdateUserIdentityCommand, UserIdentityViewModel>
    {
        private readonly IUserIdentityService _userIdentityService;
        private readonly IMapper _mapper;

        public UserIdentityCommandHandler(
            IUserIdentityService userIdentityService,
            IMapper mapper)
        {
            _userIdentityService = userIdentityService;
            _mapper = mapper;
        }

        public async Task<UserIdentityViewModel> Handle(AddUserIdentityCommand request, CancellationToken cancellationToken)
        {
            var newUserIdentityId = Guid.NewGuid();

            var createCustomerDto = _mapper.Map<UserIdentityViewModel>(request);
            createCustomerDto.UserIdentityId = newUserIdentityId;
            //createCustomerDto.IdempotencyKey = newUserIdentityId;

            var addUserIdentityDto = _mapper.Map<AddUserIdentityDto>(request);
            addUserIdentityDto.UserIdentityId = newUserIdentityId;
            var userDto = await _userIdentityService.AddUserIdentityAsync(addUserIdentityDto);

            return _mapper.Map<UserIdentityViewModel>(userDto);
        }

        public async Task<ResponseViewModel> Handle(RemoveUserIdentityCommand request, CancellationToken cancellationToken)
        {
            var userIdentityDto = await _userIdentityService.RemoveUserIdentityAsync(request.UserIdentityId);

            return new ResponseViewModel
            {
                Message = ApiResources.MessagesResources.InformationRemoveUserSuccess.Format(userIdentityDto.FullName, userIdentityDto.Email),
                Data = _mapper.Map<UserIdentityViewModel>(userIdentityDto)
            };
        }

        public async Task<UserIdentityViewModel> Handle(UpdateUserIdentityCommand request, CancellationToken cancellationToken)
        {
            var userIdentityDto = _mapper.Map<UserIdentityDto>(request);
            userIdentityDto = await _userIdentityService.UpdateUserIdentityAsync(userIdentityDto);

            return _mapper.Map<UserIdentityViewModel>(userIdentityDto);
        }
    }
}
