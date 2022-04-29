using SiadMV.API.Enums;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class UserProviderForCommand
    {
        public string AuthUId { get; set; }
        public UserProviderValue UserProviderValue { get; set; }
    }
}
