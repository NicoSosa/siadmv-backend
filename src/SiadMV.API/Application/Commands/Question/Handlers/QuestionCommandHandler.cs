using AutoMapper;
using SiadMV.API.Models.Question;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.Question;
using SiadMV.ServiceBase.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Commands.Question.Handlers
{
    public class QuestionCommandHandler :
        ICommandHandler<AddQuestionCommand, QuestionViewModel>,
        ICommandHandler<UpdateQuestionCommand, QuestionViewModel>,
        ICommandHandler<UpdateQuestionKeyFactCommand, QuestionViewModel>
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionCommandHandler(
            IQuestionService questionService,
            IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        public async Task<QuestionViewModel> Handle(AddQuestionCommand request, CancellationToken cancellationToken)
        {
            var addQuestionDto = _mapper.Map<AddQuestionDto>(request);
            var questionDto = await _questionService.CreateQuestionAsync(addQuestionDto);

            return _mapper.Map<QuestionViewModel>(questionDto);
        }

        public async Task<QuestionViewModel> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
        {
            var updateQuestionDto = _mapper.Map<UpdateQuestionDto>(request);
            var questionDto = await _questionService.UpdateQuestionAsync(updateQuestionDto);

            return _mapper.Map<QuestionViewModel>(questionDto);
        }

        public async Task<QuestionViewModel> Handle(UpdateQuestionKeyFactCommand request, CancellationToken cancellationToken)
        {
            var updateQuestionKeyFactDto = _mapper.Map<UpdateQuestionKeyFactDto>(request);
            var questionDto = await _questionService.UpdateQuestionKeyFactAsync(updateQuestionKeyFactDto);

            return _mapper.Map<QuestionViewModel>(questionDto);
        }
    }
}
