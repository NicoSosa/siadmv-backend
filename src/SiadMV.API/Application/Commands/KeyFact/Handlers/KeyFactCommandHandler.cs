using AutoMapper;
using SiadMV.API.Models.KeyFact;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Models.KeyFact;
using SiadMV.ServiceBase.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace SiadMV.API.Application.Commands.KeyFact.Handlers
{
    public class KeyFactCommandHandler :
        ICommandHandler<AddKeyFactCommand, KeyFactViewModel>,
        ICommandHandler<UpdateKeyFactCommand, KeyFactViewModel>
    {
        private readonly IKeyFactService _keyFactService;
        private readonly IMapper _mapper;

        public KeyFactCommandHandler(
            IKeyFactService keyFactService,
            IMapper mapper)
        {
            _keyFactService = keyFactService;
            _mapper = mapper;
        }

        public async Task<KeyFactViewModel> Handle(AddKeyFactCommand request, CancellationToken cancellationToken)
        {
            var addKeyFactDto = _mapper.Map<AddKeyFactDto>(request);
            var keyFactDto = await _keyFactService.CreateKeyFactAsync(addKeyFactDto);

            return _mapper.Map<KeyFactViewModel>(keyFactDto);
        }

        public async Task<KeyFactViewModel> Handle(UpdateKeyFactCommand request, CancellationToken cancellationToken)
        {
            var updateKeyFactDto = _mapper.Map<UpdateKeyFactDto>(request);
            var keyFactDto = await _keyFactService.UpdateKeyFactAsync(updateKeyFactDto);

            return _mapper.Map<KeyFactViewModel>(keyFactDto);
        }
    }
}
