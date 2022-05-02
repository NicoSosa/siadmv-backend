using AutoMapper;
using SiadMV.API.Models.KeyFact;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Queries.KeyFact.Handlers
{
    public class KeysFactListQueryHandler :
        IQueryEnumerableHandler<GetAllKeysFactQuery, IEnumerable<KeyFactViewModel>>
    {
        private readonly IKeyFactService _keyFactService;
        private readonly IMapper _mapper;

        public KeysFactListQueryHandler(
            IKeyFactService keyFactService,
            IMapper mapper)
        {
            _keyFactService = keyFactService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<KeyFactViewModel>> Handle(GetAllKeysFactQuery request, CancellationToken cancellationToken)
        {
            var keysFactDto = await _keyFactService.GetKeysFactAsync();
            return _mapper.Map<IEnumerable<KeyFactViewModel>>(keysFactDto);
        }
    }
}
