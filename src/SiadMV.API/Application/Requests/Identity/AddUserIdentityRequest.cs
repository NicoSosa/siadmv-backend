using SiadMV.API.Enums;
using MediatR;
using System;

namespace SiadMV.API.Application.Requests.Identity
{
    public class AddUserIdentityRequest : IRequest
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public UserAddressForRequest Address { get; set; }
        public UserProviderForRequest Provider { get; set; }
    }
}
