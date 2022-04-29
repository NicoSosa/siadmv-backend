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
    public class UserAddressCommandHandler :
        ICommandHandler<AddUserAddressCommand, UserAddressViewModel>,
        ICommandHandler<RemoveUserAddressCommand, ResponseViewModel>,
        ICommandHandler<UpdateUserAddressCommand, UserAddressViewModel>
    {
        private readonly IUserAddressService _userAddressService;
        private readonly IMapper _mapper;

        public UserAddressCommandHandler(
            IUserAddressService userAddressService,
            IMapper mapper)
        {
            _userAddressService = userAddressService;
            _mapper = mapper;
        }

        public async Task<UserAddressViewModel> Handle(AddUserAddressCommand request, CancellationToken cancellationToken)
        {
            var addUserAddressDto = _mapper.Map<AddUserAddressDto>(request);
            var userAddressDto = await _userAddressService.AddUserAddressAsync(addUserAddressDto);

            return _mapper.Map<UserAddressViewModel>(userAddressDto);
        }

        public async Task<ResponseViewModel> Handle(RemoveUserAddressCommand request, CancellationToken cancellationToken)
        {
            var userAddressDto = await _userAddressService.RemoveUserAddressAsync(request.UserAddressId);

            return new ResponseViewModel
            {
                Message = ApiResources.MessagesResources.InformationRemoveAddressSuccess,
                Data = _mapper.Map<UserAddressViewModel>(userAddressDto)
            };
        }

        public async Task<UserAddressViewModel> Handle(UpdateUserAddressCommand request, CancellationToken cancellationToken)
        {
            var userAddressDto = _mapper.Map<UserAddressDto>(request);
            userAddressDto = await _userAddressService.UpdateUserAddressAsync(userAddressDto);

            return _mapper.Map<UserAddressViewModel>(userAddressDto);
        }
    }
}
