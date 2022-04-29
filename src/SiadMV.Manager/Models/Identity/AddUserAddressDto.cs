using SiadMV.Manager.Enums;
using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.Identity
{
    public class AddUserAddressDto : IManagerContract
    {
        public Guid UserIdentityId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public AddressType AddressType { get; set; }
    }
}
