using MediatR;
using System;

namespace SiadMV.API.Application.Requests.KeyFact
{
    public class UpdateKeyFactRequest : IRequest
    {
        public Guid KeyFactId { get; set; }
        public string Description { get; set; }
    }
}
