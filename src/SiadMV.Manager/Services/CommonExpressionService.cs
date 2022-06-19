using AutoMapper;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.CommonExpression;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services
{
    public class CommonExpressionService : ICommonExpressionService
    {
        private readonly ISiadMVDbUoW _siadMVDbUoW;
        private readonly ICommonExpressionQueryBuilder _commonExpressionQueryBuilder;
        private readonly IMapper _mapper;

        public CommonExpressionService(
            ISiadMVDbUoW siadMVDbUoW,
            ICommonExpressionQueryBuilder commonExpressionQueryBuilder,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(siadMVDbUoW,nameof(siadMVDbUoW));
            Ensure.Parameter.IsNotNull(commonExpressionQueryBuilder, nameof(commonExpressionQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _siadMVDbUoW = siadMVDbUoW;
            _commonExpressionQueryBuilder = commonExpressionQueryBuilder;
            _mapper = mapper;

        }

        public async Task<IEnumerable<CommonExpressionDto>> GetCommonExpressionAsync()
             => await _commonExpressionQueryBuilder
                    .Start()
                    .QueryAsArrayAsync<CommonExpressionDto>();

        public async Task<CommonExpressionDto> GetCommonExpressionByIdAsync(Guid commonExpressionId)
            => await _commonExpressionQueryBuilder
                    .Start()
                    .FilterByCommonExpressionIdAsync(commonExpressionId)
                    .GetRecordAsync<CommonExpressionDto>();

        public async Task<CommonExpressionDto> CreateCommonExpressionAsync(AddCommonExpressionDto addCommonExpressionDto)
        {
            Ensure.Parameter.IsNotNull(addCommonExpressionDto, nameof(addCommonExpressionDto));

            var createdCommonExpressionDto = _siadMVDbUoW.Add(_mapper.Map<CommonExpression>(addCommonExpressionDto));

            await _siadMVDbUoW.CommitChangesAsync();
            return _mapper.Map<CommonExpressionDto>(createdCommonExpressionDto);
        }

        public async Task<CommonExpressionDto> UpdateCommonExpressionAsync(UpdateCommonExpressionDto updateCommonExpressionDto)
        {
            Ensure.Parameter.IsNotNull(updateCommonExpressionDto, nameof(updateCommonExpressionDto));

            var commonExpression = await _commonExpressionQueryBuilder
                                    .Start()
                                    .FilterByCommonExpressionIdAsync(updateCommonExpressionDto.CommonExpressionId)
                                    .GetFirstRecordAsync(true);

            if(commonExpression == null)
            {
                Raise.Error.Generic<ServiceValidationException>(ManagerResources.MessagesResources.ErrorCommonExpressionNotExist);
            }

            commonExpression.Description = updateCommonExpressionDto.Description;
            await _siadMVDbUoW.CommitChangesAsync();

            return _mapper.Map<CommonExpressionDto>(commonExpression);
        }

        public async Task<CommonExpressionDto> UpdateCommonExpressionKeyFactAsync(UpdateCommonExpressionKeyFactDto updateCommonExpressionKeyFactDto)
        {
            Ensure.Parameter.IsNotNull(updateCommonExpressionKeyFactDto, nameof(updateCommonExpressionKeyFactDto));

            var commonExpression = await _commonExpressionQueryBuilder
                              .Start()
                              .FilterByCommonExpressionIdAsync(updateCommonExpressionKeyFactDto.CommonExpressionId)
                              .GetFirstRecordAsync(true);

            if (commonExpression == null)
            {
                Raise.Error.Generic<ServiceValidationException>(ManagerResources.MessagesResources.ErrorCommonExpressionNotExist);
            }

            commonExpression.KeysFact = _mapper.Map<IList<CommonExpressionKeyFact>>(updateCommonExpressionKeyFactDto.KeysFact);

            await _siadMVDbUoW.CommitChangesAsync();

            return _mapper.Map<CommonExpressionDto>(commonExpression);
        }
    }
}
