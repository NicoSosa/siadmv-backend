using AutoMapper;
using SiadMV.API.Application.Commands.Identity;
using SiadMV.API.Application.Requests.Identity;
using SiadMV.API.Models.Identity;
using SiadMV.Manager.Models.Identity;
using SiadMV.API.Infrastructure.Extensions;
using Newtonsoft.Json;
using MGK.Extensions;
using SiadMV.API.Application.Commands.KeyFact;
using SiadMV.API.Application.Queries.KeyFact;
using SiadMV.API.Application.Requests.KeyFact;
using SiadMV.API.Application.Commands.Question;
using SiadMV.API.Application.Queries.Question;
using SiadMV.API.Application.Requests.Question;
using SiadMV.API.Application.Commands.UserCase;
using SiadMV.API.Application.Queries.UserCase;
using SiadMV.API.Application.Requests.UserCase;
using SiadMV.API.Models.KeyFact;
using SiadMV.API.Models.Question;
using SiadMV.API.Models.UserCase;
using SiadMV.Manager.Models.KeyFact;
using SiadMV.Manager.Models.Question;
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
            CreateMap<AddKeyFactRequest, AddKeyFactCommand>();
            CreateMap<AddKeyFactCommand, AddKeyFactDto>();
            CreateMap<UpdateKeyFactRequest, UpdateKeyFactCommand>();
            CreateMap<UpdateKeyFactCommand, UpdateKeyFactDto>();
            CreateMap<QuestionKeyFactDto, KeyFactViewModel>();
            CreateMap<QuestionKeyFactDto, QuestionViewModel>();
            

            CreateMap<KeyFactViewModel, KeyFactDto>()
                .ReverseMap();

            CreateMap<AddQuestionRequest, AddQuestionCommand>();
            CreateMap<AddQuestionCommand, AddQuestionDto>();
            CreateMap<QuestionKeyFactForRequest, QuestionKeyFactForCommand>();
            CreateMap<QuestionKeyFactForCommand, QuestionKeyFactDto>();
            CreateMap<UpdateQuestionRequest, UpdateQuestionCommand>();
            CreateMap<UpdateQuestionCommand, UpdateQuestionDto>();
            CreateMap<UpdateQuestionKeyFactRequest, UpdateQuestionKeyFactCommand>();
            CreateMap<UpdateQuestionKeyFactCommand, UpdateQuestionKeyFactDto>();
            CreateMap<QuestionKeyFactDto, KeyFactViewModel>();
            //.ForAllMembers(que => que.);

            CreateMap<QuestionViewModel, QuestionDto>()
                .ForMember(dest => dest.KeysFact, mo => mo.MapFrom(src => src.KeysFact))
                .ReverseMap();

            CreateMap<AddUserCaseRequest, AddUserCaseCommand>();
            CreateMap<AddUserCaseCommand, AddUserCaseDto>();
            CreateMap<UpdateUserCaseRequest, UpdateUserCaseCommand>();
            CreateMap<UpdateUserCaseCommand, UpdateUserCaseDto>();
            CreateMap<UserCaseViewModel, UserCaseDto>()
                .ReverseMap();

        }
    }
}
