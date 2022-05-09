using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using SiadMV.Manager.Services.Python.Constants;
using SiadMV.Manager.Infrastructure.Services.Python;
using MGK.Acceptance;
using System.Threading.Tasks;
using AutoMapper;

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

        public async Task<dynamic> CallScript()
        {
            string path = _configuration[ScriptsPath.SourcePath] + ScriptsPath.FolderScriptsPath + ScriptsPath.Scripts.HelloyPy;
            ScriptRuntime py = IronPython.Hosting.Python.CreateRuntime();
            dynamic pyProgram = py.UseFile(path);

            var result = pyProgram.Hi("Franco", "Casas");

            await Task.Delay(1000);

            return result;
        }
    }
}
