using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SiadMV.Manager.Infrastructure.Services.Python
{
    public interface IPythonService
    {
        Task<dynamic> CallScript();
    }
}
