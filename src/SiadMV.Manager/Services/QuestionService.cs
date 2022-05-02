using AutoMapper;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.Question;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiadMV.Manager.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly ISiadMVDbUoW _siadMVDbUoW;
        private readonly IQuestionQueryBuilder _questionQueryBuilder;
        private readonly IMapper _mapper;

        public QuestionService(
            ISiadMVDbUoW siadMVDbUoW,
            IQuestionQueryBuilder questionQueryBuilder,
            IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(siadMVDbUoW, nameof(siadMVDbUoW));
            Ensure.Parameter.IsNotNull(questionQueryBuilder, nameof(questionQueryBuilder));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _siadMVDbUoW = siadMVDbUoW;
            _questionQueryBuilder = questionQueryBuilder;
            _mapper = mapper;
        }

        public async Task<IEnumerable<QuestionDto>> GetQuestionsAsync()
            => await _questionQueryBuilder
                    .Start()
                    .QueryAsArrayAsync<QuestionDto>();

        public async Task<QuestionDto> GetQuestionByIdAsync(Guid questionId)
            => await _questionQueryBuilder
                    .Start()
                    .FilterByQuestionIdAsync(questionId)
                    .GetRecordAsync<QuestionDto>();

        public async Task<QuestionDto> CreateQuestionAsync(AddQuestionDto createQuestionDto)
        {
            Ensure.Parameter.IsNotNull(createQuestionDto, nameof(createQuestionDto));

            var createdQuestion = _siadMVDbUoW.Add(_mapper.Map<Question>(createQuestionDto));

            await _siadMVDbUoW.CommitChangesAsync();
            return _mapper.Map<QuestionDto>(createdQuestion);
        }

        public async Task<QuestionDto> UpdateQuestionAsync(UpdateQuestionDto updateQuestionDto)
        {
            Ensure.Parameter.IsNotNull(updateQuestionDto, nameof(updateQuestionDto));

            var question = await _questionQueryBuilder
                            .Start()
                            .FilterByQuestionIdAsync(updateQuestionDto.QuestionId)
                            .GetRecordAsync(true);

            if (question == null)
            {
                Raise.Error.Generic<ServiceValidationException>(ManagerResources.MessagesResources.ErrorQuestionNotExist);
            }

            question.Description = updateQuestionDto.Description;

            await _siadMVDbUoW.CommitChangesAsync();

            return _mapper.Map<QuestionDto>(question);
        }

        public async Task<QuestionDto> UpdateQuestionKeyFactAsync(UpdateQuestionKeyFactDto updateQuestionKeyFactDto)
        {
            Ensure.Parameter.IsNotNull(updateQuestionKeyFactDto, nameof(updateQuestionKeyFactDto));

            var question = await _questionQueryBuilder
                            .Start()
                            .FilterByQuestionIdAsync(updateQuestionKeyFactDto.QuestionId)
                            .GetRecordAsync(true);

            if (question == null)
            {
                Raise.Error.Generic<ServiceValidationException>(ManagerResources.MessagesResources.ErrorQuestionNotExist);
            }

            question.KeysFact = _mapper.Map<IList<QuestionKeyFact>>(updateQuestionKeyFactDto.KeysFact);

            await _siadMVDbUoW.CommitChangesAsync();

            return _mapper.Map<QuestionDto>(question);
        }
    }
}
