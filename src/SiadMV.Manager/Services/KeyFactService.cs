using AutoMapper;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.KeyFact;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services
{
    public class KeyFactService : IKeyFactService
    {
        private readonly ISiadMVDbUoW _siadMVDbUoW;
        private readonly IKeyFactQueryBuilder _keyFactQueryBuilder;
        private readonly IMapper _mapper;

        public KeyFactService(
            ISiadMVDbUoW siadMVDbUoW,
            IKeyFactQueryBuilder keyFactQueryBuilder,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(siadMVDbUoW, nameof(siadMVDbUoW));
            Ensure.Parameter.IsNotNull(keyFactQueryBuilder, nameof(keyFactQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _siadMVDbUoW = siadMVDbUoW;
            _keyFactQueryBuilder = keyFactQueryBuilder;
            _mapper = mapper;
        }

        public async Task<IEnumerable<KeyFactDto>> GetKeysFactAsync()
            => await _keyFactQueryBuilder
                    .Start()
                    .QueryAsArrayAsync<KeyFactDto>();
        public async Task<KeyFactDto> GetKeyFactByIdAsync(Guid keyFactId)
            => await _keyFactQueryBuilder
                    .Start()
                    .FilterByKeyFactIdAsync(keyFactId)
                    .GetRecordAsync<KeyFactDto>();
        public async Task<KeyFactDto> CreateKeyFactAsync(AddKeyFactDto createKeyFactDto)
        {
            Ensure.Parameter.IsNotNull(createKeyFactDto, nameof(createKeyFactDto));

            var createdKeyFact = _siadMVDbUoW.Add(_mapper.Map<KeyFact>(createKeyFactDto));

            await _siadMVDbUoW.CommitChangesAsync();
            return _mapper.Map<KeyFactDto>(createdKeyFact);
        }
        public async Task<KeyFactDto> UpdateKeyFactAsync(UpdateKeyFactDto updateKeyFactDto)
        {
            Ensure.Parameter.IsNotNull(updateKeyFactDto, nameof(updateKeyFactDto));

            var keyFact = await _keyFactQueryBuilder
                                .Start()
                                .FilterByKeyFactIdAsync(updateKeyFactDto.KeyFactId)
                                .GetRecordAsync(true);

            if (keyFact == null)
            {
                Raise.Error.Generic<ServiceValidationException>(ManagerResources.MessagesResources.ErrorKeyFactNotExist);
            }

            keyFact.Description = updateKeyFactDto.Description;

            await _siadMVDbUoW.CommitChangesAsync();

            return _mapper.Map<KeyFactDto>(keyFact);
        }
        //public async Task<KeyFactDto> RelateKeyFactToQuestionAsync(Guid keyFactId, Guid questionId);
        //public async Task<KeyFactDto> UnrelateKeyFactToQuestionAsync(Guid keyFactId, Guid questionId);
    }
}
