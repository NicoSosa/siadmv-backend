using AutoMapper;
using SiadMV.API.Models.Question;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Queries.Question.Handlers
{
    public class QuestionQueryHandler : 
        IQueryHandler<GetQuestionByIdQuery, QuestionViewModel>
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionQueryHandler(
            IQuestionService questionService,
            IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        public async Task<QuestionViewModel> Handle(GetQuestionByIdQuery request, CancellationToken cancellationToken)
        {
            var questionDto = await _questionService.GetQuestionByIdAsync(request.QuestionId);

            if (questionDto == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorQuestionNotExists);
            }

            //var questionViewModel = _mapper.Map<QuestionViewModel>(questionDto);
            //questionViewModel.KeysFact = questionDto.KeysFact.;

            return _mapper.Map<QuestionViewModel>(questionDto);
        }
    }
}
