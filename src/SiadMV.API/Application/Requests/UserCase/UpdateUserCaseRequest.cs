using MediatR;
using System;

namespace SiadMV.API.Application.Requests.UserCase
{
    public class UpdateUserCaseRequest : IRequest
    {
        public Guid UserCaseId { get; set; }
        public string Description { get; set; }
    }
}
