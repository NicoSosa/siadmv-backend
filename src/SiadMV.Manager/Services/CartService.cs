using AutoMapper;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.Manager.Models.Cart;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services
{
    public class CartService : ICartService
    {
        private readonly ISiadMVDbUoW _siadMVDbUoW;
        private readonly ICartQueryBuilder _cartQueryBuilder;
        private readonly ICartProductQueryBuilder _cartProductQueryBuilder;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IMapper _mapper;

        public CartService(
            ISiadMVDbUoW siadMVDbUoW,
            ICartQueryBuilder cartQueryBuilder,
            ICartProductQueryBuilder cartProductQueryBuilder,
            IUserIdentityService userIdentityService,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(siadMVDbUoW, nameof(siadMVDbUoW));
            Ensure.Parameter.IsNotNull(cartQueryBuilder, nameof(cartQueryBuilder));
            Ensure.Parameter.IsNotNull(cartProductQueryBuilder, nameof(cartProductQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _siadMVDbUoW = siadMVDbUoW;
            _cartQueryBuilder = cartQueryBuilder;
            _cartProductQueryBuilder = cartProductQueryBuilder;
            _userIdentityService = userIdentityService;
            _mapper = mapper;
        }

        public async Task<CartDto> UpsertCartAsync(UpsertCartDto cartDto)
        {
            await _userIdentityService.ValidateIfUserExistsByIdAsync(cartDto.UserIdentityId);

            Guid cartId = Guid.Empty;

            var cart = await _cartQueryBuilder
                   .Start()
                   .FilterByUserIdentityId(cartDto.UserIdentityId)
                   .IncludeCartProducts()
                   .GetRecordAsync(true);

            if (cart == null)
            {
                cartId = Guid.NewGuid();
                cart = _mapper.Map<UpsertCartDto, Cart>(
                    cartDto,
                    opt => opt.AfterMap(
                        (src, dest) =>
                        {
                            dest.Id = cartId;
                            ((List<CartProduct>)dest.CartProducts).ForEach(cp => cp.CartId = cartId);
                        }));

                cart.CreationDate = DateTime.UtcNow;
                _siadMVDbUoW.Add(cart);
            }
            else
            {
                cartId = cart.Id;
                var cartProductsToRemove = await _cartProductQueryBuilder
                    .Start()
                    .FilterByCartIdAsync(cartId)
                    .QueryAsArrayAsync(true);

                _siadMVDbUoW.RemoveRange(cartProductsToRemove);

                cart = _mapper.Map(cartDto, cart);
                cart.LastUpdateDate = DateTime.UtcNow;
            }

            await _siadMVDbUoW.CommitChangesAsync();
            return _mapper.Map<CartDto>(cart);
        }

        public async Task<CartDto> GetCartByIdAsync(Guid cartId)
        {
            var cartDto = await _cartQueryBuilder
                            .Start()
                            .FilterById(cartId)
                            .IncludeCartProducts()
                            .GetRecordAsync<CartDto>();
            cartDto.Price = await CalculateCartPriceAsync(cartDto);
            return cartDto;
        }

        public async Task<CartDto> GetCartByUserIdentityIdAsync(Guid userIdentityId)
        {
            var cartDto = await _cartQueryBuilder
                            .Start()
                            .FilterByUserIdentityId(userIdentityId)
                            .IncludeCartProducts()
                            .GetRecordAsync<CartDto>();
            cartDto.Price = await CalculateCartPriceAsync(cartDto);
            return cartDto;
        }

        private async Task<decimal> CalculateCartPriceAsync(CartDto cartDto)
        {
            IEnumerable<Guid> productsIdList = cartDto.CartProducts.Select(product => product.ProductId);
            //IEnumerable<ProductDto> productsListDto = await _productService.GetProductsByIdsListAsync(productsIdList);

            //var productGroup = from cartProduct in cartDto.CartProducts
            //                   join productDto in productsListDto on cartProduct.ProductId equals productDto.ProductId
            //                   select new { Quantity = cartProduct.Quantity, UnitPrice = productDto.UnitPrice };

            var varDecimal = new decimal();
            return varDecimal;
        }
    }
}
