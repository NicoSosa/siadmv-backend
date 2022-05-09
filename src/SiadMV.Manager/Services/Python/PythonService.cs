using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using SiadMV.Manager.Constants;
using SiadMV.Manager.Infrastructure.Services.Python;
using MGK.Acceptance;
using System.Threading.Tasks;
using AutoMapper;
using SiadMV.Manager.Models.Python;

namespace SiadMV.Manager.Services.Python
{
    class PythonService : IPythonService
    {

        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public PythonService(
            IMapper mapper,
            IConfiguration configuration)
        {
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));
            Ensure.Parameter.IsNotNull(configuration, nameof(configuration));

            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<dynamic> GetInfraestructureByKeysFactAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<dynamic> SearchKeysFactInUserCaseAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> TestScriptAsync()
        {
            string path = _configuration[PythonPaths.SourcePath] + PythonPaths.FolderScriptsPath + PythonPaths.Scripts.HelloyPy;
            var testDto = new PythonTestDto();
            testDto.name = "Franco";
            testDto.lastName = "Casas";


            dynamic pyProgram = CallScript(path);

            var result = pyProgram.Hi(testDto.name, testDto.lastName);

            await Task.Delay(1000);
            return result;
        }


        private dynamic CallScript(string path)
        {
            
            ScriptRuntime py = IronPython.Hosting.Python.CreateRuntime();
            dynamic pyProgram = py.UseFile(path);
            return pyProgram;
        }
    }
}
