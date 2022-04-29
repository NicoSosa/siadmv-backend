using SiadMV.API.Enums;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Infrastructure.Contracts.Identity
{
    public interface IUserAddressContract : IContract
    {
        string Address1 { get; }
        string Address2 { get; }
        string City { get; }
        string State { get; }
        string Zipcode { get; }
        public AddressType AddressType { get; }
        Guid UserIdentityId { get; }
    }
}
