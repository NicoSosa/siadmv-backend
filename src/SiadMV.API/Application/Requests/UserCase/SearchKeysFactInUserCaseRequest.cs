using MediatR;

namespace SiadMV.API.Application.Requests.UserCase
{
    public class SearchKeysFactInUserCaseRequest : IRequest
    {
        public string Description { get; set; }
    }
}
