using AutoMapper;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.Manager.Models.Identity;
using System;
using MGK.Extensions;
using SiadMV.Manager.Enums;
using SiadMV.Manager.Models.CommonExpression;
using SiadMV.Manager.Models.KeyFact;
using SiadMV.Manager.Models.Question;
using SiadMV.Manager.Models.UserCase;

namespace SiadMV.Manager.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserIdentity, UserIdentityDto>()
                .ForMember(dest => dest.UserIdentityId, mo => mo.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<AddUserIdentityDto, UserIdentity>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = src.UserIdentityId;
                })
                .ForMember(dest => dest.CreationDate, mo => mo.MapFrom(_ => DateTime.UtcNow));

            CreateMap<UserAddress, UserAddressDto>()
                .ForMember(dest => dest.UserAddressId, mo => mo.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<AddUserAddressDto, UserAddress>()
                .ForMember(dest => dest.Id, mo => mo.MapFrom(_ => Guid.NewGuid()))
                .ForMember(dest => dest.CreationDate, mo => mo.MapFrom(_ => DateTime.UtcNow));

            CreateMap<AddUserProviderDto, UserProvider>()
                .ForMember(dest => dest.Id, mo => mo.MapFrom(src => src.AuthUId))
                .ReverseMap();

            CreateMap<UserProvider, UserProviderDto>()
                .ForMember(dest => dest.AuthUId, mo => mo.MapFrom(src => src.Id))
                .ReverseMap();


            // Mapping From SiadMV DB
            CreateMap<AddKeyFactDto, KeyFact>();
            CreateMap<UpdateKeyFactDto, KeyFact>();
            CreateMap<KeyFact, KeyFactDto>()
                .ForMember(dest => dest.KeyFactId, mo => mo.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<AddQuestionDto, Question>();
            CreateMap<UpdateQuestionDto, Question>();
            CreateMap<UpdateQuestionKeyFactDto, Question>();
            CreateMap<Question, QuestionDto>()
                .ForMember(dest => dest.QuestionId, mo => mo.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<QuestionKeyFact, QuestionKeyFactDto>()
                .ReverseMap();

            CreateMap<AddCommonExpressionDto, CommonExpression>();
            CreateMap<UpdateCommonExpressionDto, CommonExpression>();
            CreateMap<UpdateCommonExpressionKeyFactDto, CommonExpression>();
            CreateMap<CommonExpression, CommonExpressionDto>()
                .ForMember(dest => dest.CommonExpressionId, mo => mo.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<CommonExpressionKeyFact, CommonExpressionKeyFactDto>()
                .ReverseMap();

            CreateMap<AddUserCaseDto, UserCase>();
            CreateMap<UpdateUserCaseDto, UserCase>();
            CreateMap<UserCase, UserCaseDto>()
                .ForMember(dest => dest.UserCaseId, mo => mo.MapFrom(src => src.Id))
                .ReverseMap();
        }
    }
}
