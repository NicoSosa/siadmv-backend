using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Infrastructure.Contracts
{
    interface IResponsePoCViewModel : IContract
    {
        public object Data { get; }
    }
}
