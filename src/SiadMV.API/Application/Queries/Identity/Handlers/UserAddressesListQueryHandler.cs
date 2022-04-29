using AutoMapper;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.Identity.Handlers
{
    public class UserAddressesListQueryHandler :
        IQueryEnumerableHandler<GetUserAddressesByUserIdentityIdQuery, IEnumerable<UserAddressViewModel>>
    {
        private readonly IUserAddressService _userAddressService;
        private readonly IMapper _mapper;

        public UserAddressesListQueryHandler(
            IUserAddressService userAddressService,
            IMapper mapper)
        {
            _userAddressService = userAddressService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserAddressViewModel>> Handle(GetUserAddressesByUserIdentityIdQuery request, CancellationToken cancellationToken)
        {
            var userAddresses = await _userAddressService.GetAddressByUserIdentityIdAsync(request.UserIdentityId);
            if (userAddresses == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorUserAddressNotExists);
            }
            return _mapper.Map<IEnumerable<UserAddressViewModel>>(userAddresses);
        }
    }
}
