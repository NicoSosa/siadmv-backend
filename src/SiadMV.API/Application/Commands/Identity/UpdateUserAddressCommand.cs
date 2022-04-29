using SiadMV.API.Enums;
using SiadMV.API.Models.Identity;
using EmpanadUS.ServiceBase.CQRS.Commands;
using System;

namespace SiadMV.API.Application.Commands.Identity
{
    public class UpdateUserAddressCommand : CommandBase<UserAddressViewModel>
    {
        public Guid UserAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public AddressType AddressType { get; set; }
    }
}
