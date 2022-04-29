using AutoMapper;
using SiadMV.API.Application.Commands.Identity;
using SiadMV.API.Application.Requests.Identity;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Models.Identity;
using SiadMV.API.Infrastructure.Extensions;
using Newtonsoft.Json;
using SiadMV.API.Application.Requests.Cart;
using SiadMV.API.Application.Commands.Cart;
using SiadMV.API.Models.Cart;
using SiadMV.Manager.Models.Cart;
using MGK.Extensions;

namespace SiadMV.API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddUserIdentityRequest, AddUserIdentityCommand>();
            CreateMap<AddUserIdentityCommand, AddUserIdentityDto>();
            CreateMap<UserIdentityDto, UserIdentityViewModel>();

            CreateMap<UserAddressForRequest, UserAddressForCommand>();
            CreateMap<UserAddressForCommand, UserAddressDto>();

            CreateMap<UserProviderForRequest, UserProviderForCommand>();
            CreateMap<UserProviderForCommand, UserProviderDto>();

            CreateMap<UpdateUserIdentityRequest, UpdateUserIdentityCommand>();
            CreateMap<UpdateUserIdentityCommand, UserIdentityDto>();

            CreateMap<AddUserAddressRequest, AddUserAddressCommand>();
            CreateMap<AddUserAddressCommand, AddUserAddressDto>();
            CreateMap<UserAddressViewModel, UserAddressDto>()
                .ReverseMap();

            CreateMap<AddUserProviderRequest, AddUserProviderCommand>();
            CreateMap<AddUserProviderCommand, AddUserProviderDto>();
            CreateMap<UserProviderViewModel, UserProviderDto>()
                .ReverseMap();

            CreateMap<UpdateUserAddressRequest, UpdateUserAddressCommand>();
            CreateMap<UpdateUserAddressCommand, UserAddressDto>();

            CreateMap<UpsertCartRequest, UpsertCartCommand>();
            CreateMap<UpsertCartCommand, UpsertCartDto>();
            CreateMap<CartDto, CartViewModel>()
                .ReverseMap();
            CreateMap<CartProductForRequest, CartProductForCommand>();
            CreateMap<CartProductForCommand, CartProductDto>();
            CreateMap<CartProductDto, CartProductViewModel>()
                .ReverseMap();
        }
    }
}
