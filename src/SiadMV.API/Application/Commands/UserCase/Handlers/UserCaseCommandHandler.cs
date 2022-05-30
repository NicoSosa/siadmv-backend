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
    //ICommandHandler<SearchKeysFactInUserCaseCommand, UserCaseViewModel>
    {
        private readonly IUserCaseService _userCaseService;
        private readonly IPythonService _pythonService;
        private readonly IMapper _mapper;
        public UserCaseCommandHandler(
            IUserCaseService userCaseService,
            IPythonService pythonService,
            IMapper mapper)
        {
            _userCaseService = userCaseService;
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
        //public async Task<UserCaseViewModel> Handle(SearchKeysFactInUserCaseCommand request, CancellationToken cancellationToken)
        {
            var searchDto = _mapper.Map<SearchKeysFactInUserCaseDto>(request);

            // ToDo: create getSelectTextsAsArray method in keyFactService and call it here.
            string[] array = { "de", "sql", "SQL", "MY-SQL", "my-sql", "MYSQL", "mysql", "NOSQL", "nosql", "NO-SQL", "no-sql", "python", "backend", "usuario", "backend", "frontend", "login", "mortadela", "ya no se que poner", "esto es una prueba", "vamos por mas ", "rico aprobanos", "php", "PHP", "web", "api", "API", "base de datos", "Base de datos", "Base de Datos", "sistema", "control", "red", "Red" };
            searchDto.KeysFact = array;

            var pyServiceData = await _pythonService.SearchKeysFactInUserCaseAsync(searchDto);
            var result = new ResponseViewModel();
            result.Data = pyServiceData;
            //var result = new UserCaseViewModel();

            // ToDo: Create getRecommendedInfrastructure(result) method in pythonService
            //return _mapper.Map<UserCaseViewModel>(result);
            return result;
        }
    }
}
