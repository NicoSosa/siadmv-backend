using SiadMV.API.Enums;
using MediatR;
using System;

namespace SiadMV.API.Application.Requests.Identity
{
    public class AddUserProviderRequest: IRequest
    {
        public string AuthUId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
        public Guid UserIdentityId { get; set; }
    }
}
