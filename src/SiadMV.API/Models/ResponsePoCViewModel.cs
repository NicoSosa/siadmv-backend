using SiadMV.API.Infrastructure.Contracts;
using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Models
{
    public class ResponsePoCViewModel : IResponsePoCViewModel, IResponse
    {
        public object Data { get; set; }
    }
}
