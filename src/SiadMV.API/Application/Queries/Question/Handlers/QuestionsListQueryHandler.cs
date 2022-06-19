using AutoMapper;
using SiadMV.API.Models.Question;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.Question.Handlers
{
    public class QuestionsListQueryHandler  : 
        IQueryEnumerableHandler<GetAllQuestionsQuery, IEnumerable<QuestionViewModel>>
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionsListQueryHandler(
            IQuestionService questionService,
            IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<QuestionViewModel>> Handle(GetAllQuestionsQuery request, CancellationToken cancellationToken)
        {
            var questionsDto = await _questionService.GetQuestionsAsync();
            return _mapper.Map<IEnumerable<QuestionViewModel>>(questionsDto);
        }
    }
}
