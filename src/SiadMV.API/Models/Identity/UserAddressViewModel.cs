using SiadMV.API.Enums;
using SiadMV.API.Infrastructure.Contracts.Identity;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Models.Identity
{
    public class UserAddressViewModel : IUserAddressContract, IResponse
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
