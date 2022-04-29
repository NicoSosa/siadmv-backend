using SiadMV.API.Enums;
using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Commands;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class AddUserAddressCommand : CommandBase<UserAddressViewModel>
    {
        public Guid userIdentityId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public AddressType AddressType { get; set; }
    }
}
