using SiadMV.Manager.Enums;
using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.Identity
{
    public class UserAddressDto : IManagerContract, IManagerResponse
    {
        public Guid UserAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public AddressType AddressType { get; set; }
        public Guid UserIdentityId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
