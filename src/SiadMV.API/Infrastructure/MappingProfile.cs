using AutoMapper;
using SiadMV.API.Application.Commands.Identity;
using SiadMV.API.Application.Requests.Identity;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Models.Identity;
using SiadMV.API.Infrastructure.Extensions;
using Newtonsoft.Json;
using MGK.Extensions;
using SiadMV.API.Models.UserCase;
using SiadMV.Manager.Models.UserCase;

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

            // Mapping for SiadMv
            //CreateMap<UserCaseRequest, UserCaseCommand>();
            CreateMap<UserCaseViewModel, UserCaseDto>()
                .ReverseMap();
        }
    }
}
