using SiadMV.Manager.Models.UserCase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SiadMV.Manager.Infrastructure.Services.Python
{
    public interface IPythonService
    {
        Task<dynamic> GetInfraestructureByKeysFactAsync();
        Task<dynamic> SearchKeysFactInUserCaseAsync(SearchKeysFactInUserCaseDto searchDto);
        Task<string> TestScriptAsync();
    }
}
