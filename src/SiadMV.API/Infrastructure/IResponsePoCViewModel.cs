using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Infrastructure
{
    public interface IResponsePoCViewModel : IContract
    {
        public dynamic Description { get; }
    }
}
