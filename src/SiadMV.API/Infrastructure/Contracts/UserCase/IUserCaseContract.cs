using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Infrastructure.Contracts.UserCase
{
    public interface IUserCaseContract : IContract
    {
        public Guid UserCaseId { get;  }
        public string Description { get; }
    }
}
