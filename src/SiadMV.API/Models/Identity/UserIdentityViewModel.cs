using SiadMV.API.Enums;
using SiadMV.API.Infrastructure.Contracts.Identity;
using EmpanadUS.ServiceBase.CQRS.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Models.Identity
{
    public class UserIdentityViewModel : IUserIdentityContract, IResponse
    {
        public Guid UserIdentityId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string CustomerSquareId { get; set; }
        public IList<UserAddressViewModel> Addresses { get; set; }
        public IList<UserProviderViewModel> Providers { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }

    }
}
