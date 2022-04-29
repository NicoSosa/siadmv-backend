using SiadMV.API.Enums;
using MediatR;
using System;

namespace SiadMV.API.Application.Requests.Identity
{
    public class UpdateUserIdentityRequest :IRequest
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
