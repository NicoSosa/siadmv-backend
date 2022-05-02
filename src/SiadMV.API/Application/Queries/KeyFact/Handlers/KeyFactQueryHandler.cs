using AutoMapper;
using SiadMV.API.Models.KeyFact;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.ServiceBase.CQRS.Queries;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MGK.Acceptance;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Queries.KeyFact.Handlers
{
    public class KeyFactQueryHandler :
        IQueryHandler<GetKeyFactByIdQuery, KeyFactViewModel>
    {
        private readonly IKeyFactService _keyFactService;
        private readonly IMapper _mapper;
        public KeyFactQueryHandler(
            IKeyFactService keyFactService,
            IMapper mapper)
        {
            _keyFactService = keyFactService;
            _mapper = mapper;
        }

        public async Task<KeyFactViewModel> Handle(GetKeyFactByIdQuery request, CancellationToken cancellationToken)
        {
            var keyFactDto = await _keyFactService.GetKeyFactByIdAsync(request.KeyFactId);

            if (keyFactDto == null)
            {
                Raise.Error.Generic<NotFoundException>(ApiResources.MessagesResources.ErrorKeyFactNotExists);
            }

            return _mapper.Map<KeyFactViewModel>(keyFactDto);
        }
    }
}
