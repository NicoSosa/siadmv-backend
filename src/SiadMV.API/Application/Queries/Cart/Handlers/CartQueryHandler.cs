using AutoMapper;
using SiadMV.API.Models.Cart;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.Cart.Handlers
{
    public class CartQueryHandler :
        IQueryHandler<GetCartByIdQuery, CartViewModel>,
        IQueryHandler<GetCartByUserIdentityIdQuery, CartViewModel>
    {
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;

        public CartQueryHandler(
            ICartService cartService,
            IMapper mapper)
        {
            _cartService = cartService;
            _mapper = mapper;
        }

        public async Task<CartViewModel> Handle(GetCartByIdQuery request, CancellationToken cancellationToken)
        {
            var cartDto = await _cartService.GetCartByIdAsync(request.CartId);

            if (cartDto == null)
            {
                Raise.Error.Generic<NotFoundException>(
                    ApiResources.MessagesResources.ErrorCartNotExists);
            }

            return _mapper.Map<CartViewModel>(cartDto);
        }

        public async Task<CartViewModel> Handle(GetCartByUserIdentityIdQuery request, CancellationToken cancellationToken)
        {
            var cartDto = await _cartService.GetCartByUserIdentityIdAsync(request.UserIdentityId);

            if (cartDto == null)
            {
                Raise.Error.Generic<NotFoundException>(
                    ApiResources.MessagesResources.ErrorCartNotExists);
            }

            return _mapper.Map<CartViewModel>(cartDto);
        }
    }
}
