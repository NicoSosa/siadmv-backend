using AutoMapper;
using SiadMV.API.Models.CommonExpression;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.CommonExpression;
using SiadMV.ServiceBase.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Commands.CommonExpression.Handlers
{
    public class CommonExpressionCommandHandler :
        ICommandHandler<AddCommonExpressionCommand, CommonExpressionViewModel>,
        ICommandHandler<UpdateCommonExpressionCommand, CommonExpressionViewModel>,
        ICommandHandler<UpdateCommonExpressionKeyFactCommand, CommonExpressionViewModel>
    {
        private readonly ICommonExpressionService _commonExpressionService;
        private readonly IMapper _mapper;
        public CommonExpressionCommandHandler(
            ICommonExpressionService commonExpressionService,
            IMapper mapper)
        {
            _commonExpressionService = commonExpressionService;
            _mapper = mapper;
        }

        public async Task<CommonExpressionViewModel> Handle(AddCommonExpressionCommand request, CancellationToken cancellationToken)
        {
            var addCommonExpressionDto = _mapper.Map<AddCommonExpressionDto>(request);
            var commonExpressionDto = await _commonExpressionService.CreateCommonExpressionAsync(addCommonExpressionDto);

            return _mapper.Map<CommonExpressionViewModel>(commonExpressionDto);
        }

        public async Task<CommonExpressionViewModel> Handle(UpdateCommonExpressionCommand request, CancellationToken cancellationToken)
        {
            var updateCommonExpressionDto = _mapper.Map<UpdateCommonExpressionDto>(request);
            var commonExpressionDto = await _commonExpressionService.UpdateCommonExpressionAsync(updateCommonExpressionDto);

            return _mapper.Map<CommonExpressionViewModel>(commonExpressionDto);
        }
        public async Task<CommonExpressionViewModel> Handle(UpdateCommonExpressionKeyFactCommand request, CancellationToken cancellationToken)
        {
            var updateCommonExpressionKeyFactDto = _mapper.Map<UpdateCommonExpressionKeyFactDto>(request);
            var commonExpressionDto = await _commonExpressionService.UpdateCommonExpressionKeyFactAsync(updateCommonExpressionKeyFactDto);

            return _mapper.Map<CommonExpressionViewModel>(commonExpressionDto);
        }


    }
}
