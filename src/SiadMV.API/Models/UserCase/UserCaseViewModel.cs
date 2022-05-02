using SiadMV.API.Infrastructure.Contracts.UserCase;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Models.UserCase
{
    public class UserCaseViewModel : IUserCaseContract, IResponse
    {
        public Guid UserCaseId { get; set; }
        public string Description { get; set; }
    }
}
