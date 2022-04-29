using SiadMV.API.Models.Identity;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System.Collections.Generic;

namespace SiadMV.API.Infrastructure.Contracts.Identity
{
    public interface IUserIdentityContract : IContract
    {
        string Email { get; }
        string FirstName { get; }
        string Surname { get; }
        string Phone { get; }
        public string CustomerSquareId { get; }
        IList<UserAddressViewModel> Addresses { get; }
        IList<UserProviderViewModel> Providers { get; }
    }
}
