using MediatR;

namespace SiadMV.API.Application.Requests.UserCase
{
    public class AddUserCaseRequest : IRequest
    {
        public string Description { get; set; }
    }
}
