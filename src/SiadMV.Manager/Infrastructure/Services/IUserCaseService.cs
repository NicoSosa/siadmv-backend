using SiadMV.Manager.Models.UserCase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services
{
    public interface IUserCaseService
    {
        Task<IEnumerable<UserCaseDto>> GetUserCasesAsync();
        Task<UserCaseDto> GetUserCaseByIdAsync(Guid userCaseId);
        Task<UserCaseDto> GetRandomUserCaseAsync();
        Task<UserCaseDto> CreateUserCaseAsync(AddUserCaseDto createUserCaseDto);
        Task<UserCaseDto> UpdateUserCaseAsync(UpdateUserCaseDto updateUserCaseDto);
    }
}
