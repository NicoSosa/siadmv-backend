using AutoMapper;
using SiadMV.API.Models.CommonExpression;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Queries.CommonExpression.Handlers
{
    public class CommonExpressionQueryHandler :
        IQueryHandler<GetCommonExpressionByIdQuery, CommonExpressionViewModel>
    {
        private readonly ICommonExpressionService _commonExpressionService;
        private readonly IMapper _mapper;
        public CommonExpressionQueryHandler(
            ICommonExpressionService commonExpressionService,
            IMapper mapper)
        {
            _commonExpressionService = commonExpressionService;
            _mapper = mapper;
        }
        public async Task<CommonExpressionViewModel> Handle(GetCommonExpressionByIdQuery request, CancellationToken cancellationToken)
        {
            var commonExpressionDto = await _commonExpressionService.GetCommonExpressionByIdAsync(request.CommonExpressionId);
            if(commonExpressionDto == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorCommonExpressionNotExists);
            }

            return _mapper.Map<CommonExpressionViewModel>(commonExpressionDto);
        }
    }
}
