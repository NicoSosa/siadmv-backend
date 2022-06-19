using SiadMV.Manager.Models.CommonExpression;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services
{
    public interface ICommonExpressionService
    {
        Task<IEnumerable<CommonExpressionDto>> GetCommonExpressionAsync();
        Task<CommonExpressionDto> GetCommonExpressionByIdAsync(Guid commonExpressionId);
        Task<CommonExpressionDto> CreateCommonExpressionAsync(AddCommonExpressionDto addCommonExpressionDto);
        Task<CommonExpressionDto> UpdateCommonExpressionAsync(UpdateCommonExpressionDto updateCommonExpressionDto);
        Task<CommonExpressionDto> UpdateCommonExpressionKeyFactAsync(UpdateCommonExpressionKeyFactDto updateCommonExpressionKeyFactDto);
    }
}
