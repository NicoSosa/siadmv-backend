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
    public class UserAddressQueryHandler :
        IQueryHandler<GetUserAddressQuery, UserAddressViewModel>
    {
        private readonly IUserAddressService _userAddressService;
        private readonly IMapper _mapper;

        public UserAddressQueryHandler(
            IUserAddressService userAddressService,
            IMapper mapper)
        {
            _userAddressService = userAddressService;
            _mapper = mapper;
        }

        public async Task<UserAddressViewModel> Handle(GetUserAddressQuery request, CancellationToken cancellation)
        {
            var userAddressDto = await _userAddressService.GetUserAddressByIdAsync(request.UserAddressId);
            if (userAddressDto == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserAddressNotExists);
            }

            return _mapper.Map<UserAddressViewModel>(userAddressDto);
        }
    }
}
