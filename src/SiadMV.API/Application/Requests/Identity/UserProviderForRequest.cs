using SiadMV.API.Enums;
using System;

namespace SiadMV.API.Application.Requests.Identity
{
    public class UserProviderForRequest
    {
        public string AuthUId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
        public Guid UserIdentityId { get; set; }
    }
}
