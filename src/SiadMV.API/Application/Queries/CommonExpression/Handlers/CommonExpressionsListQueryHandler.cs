using AutoMapper;
using SiadMV.API.Models.CommonExpression;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.CommonExpression.Handlers
{
    public class CommonExpressionsListQueryHandler :
        IQueryEnumerableHandler<GetAllCommonExpressionsQuery, IEnumerable<CommonExpressionViewModel>>
    {
        private readonly ICommonExpressionService _commonExpressionService;
        private readonly IMapper _mapper;
        public CommonExpressionsListQueryHandler(
            ICommonExpressionService commonExpressionService,
            IMapper mapper)
        {
            _commonExpressionService = commonExpressionService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CommonExpressionViewModel>> Handle(GetAllCommonExpressionsQuery request, CancellationToken cancellationToken)
        {
            var commonExpressionsDto = await _commonExpressionService.GetCommonExpressionAsync();
            return _mapper.Map<IEnumerable<CommonExpressionViewModel>>(commonExpressionsDto);
        }
    }
}
