using AutoMapper;
using SiadMV.API.Models;
using SiadMV.API.Models.UserCase;
using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Infrastructure.Services.Python;
using SiadMV.Manager.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Commands;
using System.Threading;
using System.Threading.Tasks;


namespace SiadMV.API.Application.Commands.UserCase.Handlers
{
    public class UserCaseCommandHandler :
        ICommandHandler<AddUserCaseCommand, UserCaseViewModel>,
        ICommandHandler<UpdateUserCaseCommand, UserCaseViewModel>,
        ICommandHandler<SearchKeysFactInUserCaseCommand, ResponseViewModel>
    {
        private readonly IUserCaseService _userCaseService;
        private readonly ICommonExpressionService _commonExpressionService;
        private readonly IPythonService _pythonService;
        private readonly IMapper _mapper;
        public UserCaseCommandHandler(
            IUserCaseService userCaseService,
            ICommonExpressionService commonExpressionService,
            IPythonService pythonService,
            IMapper mapper)
        {
            _userCaseService = userCaseService;
            _commonExpressionService = commonExpressionService;
            _pythonService = pythonService;
            _mapper = mapper;
        }

        public async Task<UserCaseViewModel> Handle(AddUserCaseCommand request, CancellationToken cancellationToken)
        {
            var addUserCaseDto = _mapper.Map<AddUserCaseDto>(request);
            var UserCaseDto = await _userCaseService.CreateUserCaseAsync(addUserCaseDto);

            return _mapper.Map<UserCaseViewModel>(UserCaseDto);
        }

        public async Task<UserCaseViewModel> Handle(UpdateUserCaseCommand request, CancellationToken cancellationToken)
        {
            var updateUserCaseDto = _mapper.Map<UpdateUserCaseDto>(request);
            var UserCaseDto = await _userCaseService.UpdateUserCaseAsync(updateUserCaseDto);

            return _mapper.Map<UserCaseViewModel>(UserCaseDto);
        }

        public async Task<ResponseViewModel> Handle(SearchKeysFactInUserCaseCommand request, CancellationToken cancellationToken)
        {
            var searchDto = _mapper.Map<SearchKeysFactInUserCaseDto>(request);
            // get commonExpressionsAsArray
            var commonExpressionArray = await _commonExpressionService.GetCommonExpressionAsync();

            // ToDo: create getSelectTextsAsArray method in keyFactService and call it here.
            string[] array = { "sql", "SQL", "MY-SQL", "my-sql", "MYSQL", "mysql", "NOSQL", "nosql", "NO-SQL", "no-sql", "python", "backend", "usuario", "backend", "frontend", "login", "php", "PHP", "web", "api", "API", "base de datos", "Base de datos", "Base de Datos", "sistema", "control", "red", "Red" };
            searchDto.KeysFact = array;

            var pyServiceData = await _pythonService.SearchKeysFactInUserCaseAsync(searchDto);
            var result = new ResponseViewModel();
            result.Data = pyServiceData;

            // ToDo: Create getRecommendedInfrastructure(result) method in pythonService
            return result;
        }
    }
}
