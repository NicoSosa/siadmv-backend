using MediatR;

namespace SiadMV.API.Application.Requests.KeyFact
{
    public class AddKeyFactRequest : IRequest
    {
        public string Description { get; set; }
    }
}
