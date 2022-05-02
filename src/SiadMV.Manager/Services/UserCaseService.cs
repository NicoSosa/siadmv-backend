using AutoMapper;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.UserCase;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services
{
    public class UserCaseService : IUserCaseService
    {
        private readonly ISiadMVDbUoW _siadMVDbUoW;
        private readonly IUserCaseQueryBuilder _userCaseQueryBuilder;
        private readonly IMapper _mapper;

        public UserCaseService(
            ISiadMVDbUoW siadMVDbUoW,
            IUserCaseQueryBuilder userCaseQueryBuilder,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(siadMVDbUoW, nameof(siadMVDbUoW));
            Ensure.Parameter.IsNotNull(userCaseQueryBuilder, nameof(userCaseQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _siadMVDbUoW = siadMVDbUoW;
            _userCaseQueryBuilder = userCaseQueryBuilder;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserCaseDto>> GetUserCasesAsync()
            => await _userCaseQueryBuilder
                    .Start()
                    .QueryAsArrayAsync<UserCaseDto>();
        public async Task<UserCaseDto> GetUserCaseByIdAsync(Guid userCaseId)
            => await _userCaseQueryBuilder
                    .Start()
                    .FilterByUserCaseIdAsync(userCaseId)
                    .GetRecordAsync<UserCaseDto>();
        public async Task<UserCaseDto> GetRandomUserCaseAsync()
        { 
            // ToDo: logic of this method. Now it get ALL the userCases and then randomize one record.
            var userCases = await GetUserCasesAsync();
            var rand = new Random();
            var randomUserCase = userCases.ElementAt(rand.Next(userCases.Count()));
            return randomUserCase;
        }
        
        public async Task<UserCaseDto> CreateUserCaseAsync(CreateUserCaseDto createUserCaseDto)
        {
            Ensure.Parameter.IsNotNull(createUserCaseDto, nameof(createUserCaseDto));

            var createdUserCase = _siadMVDbUoW.Add(_mapper.Map<UserCase>(createUserCaseDto));

            await _siadMVDbUoW.CommitChangesAsync();
            return _mapper.Map<UserCaseDto>(createdUserCase);

        }
        public async Task<UserCaseDto> UpdateUserCaseAsync(UpdateUserCaseDto updateUserCaseDto)
        {
            Ensure.Parameter.IsNotNull(updateUserCaseDto, nameof(updateUserCaseDto));

            var userCase = await _userCaseQueryBuilder
                            .Start()
                            .FilterByUserCaseIdAsync(updateUserCaseDto.UserCaseId)
                            .GetRecordAsync(true);

            if (userCase == null)
            {
                Raise.Error.Generic<ServiceValidationException>(ManagerResources.MessagesResources.ErrorUserCaseNotExist);
            }

            userCase.Description = updateUserCaseDto.Description;

            await _siadMVDbUoW.CommitChangesAsync();

            return _mapper.Map<UserCaseDto>(userCase);
        }

    }
}
