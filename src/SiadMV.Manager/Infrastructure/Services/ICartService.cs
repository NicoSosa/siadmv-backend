using SiadMV.Manager.Models.Cart;
using System;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services
{
    public interface ICartService
    {
        Task<CartDto> UpsertCartAsync(UpsertCartDto cartDto);
        Task<CartDto> GetCartByIdAsync(Guid cartId);
        Task<CartDto> GetCartByUserIdentityIdAsync(Guid userIdentityId);
    }
}
