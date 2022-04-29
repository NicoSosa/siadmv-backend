using AutoMapper;
using SiadMV.API.Models.Cart;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.Cart;
using SiadMV.ServiceBase.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Commands.Cart.Handlers
{
    public class CartCommandHandler : ICommandHandler<UpsertCartCommand, CartViewModel>
    {
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;

        public CartCommandHandler(
            ICartService cartService,
            IMapper mapper)
        {
            _cartService = cartService;
            _mapper = mapper;
        }

        public async Task<CartViewModel> Handle(UpsertCartCommand request, CancellationToken cancellationToken)
        {
            var upsertCartDto = _mapper.Map<UpsertCartDto>(request);
            var cartDto = await _cartService.UpsertCartAsync(upsertCartDto);

            return _mapper.Map<CartViewModel>(cartDto);
        }
    }
}
