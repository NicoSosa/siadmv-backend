using SiadMV.Manager.Models.KeyFact;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services
{
    public interface IKeyFactService
    {
        Task<IEnumerable<KeyFactDto>> GetKeysFactAsync();
        Task<KeyFactDto> GetKeyFactByIdAsync(Guid keyFactId);
        Task<KeyFactDto> CreateKeyFactAsync(CreateKeyFactDto createKeyFactDto);
        Task<KeyFactDto> UpdateKeyFactAsync(UpdateKeyFactDto updateKeyFactDto);
        //Task<KeyFactDto> RelateKeyFactToQuestionAsync(Guid keyFactId, Guid questionId);
        //Task<KeyFactDto> UnrelateKeyFactToQuestionAsync(Guid keyFactId, Guid questionId);
    }
}
