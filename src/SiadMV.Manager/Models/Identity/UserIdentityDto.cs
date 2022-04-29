using SiadMV.Manager.Enums;
using SiadMV.Manager.SeedWork;
using System;
using System.Collections.Generic;

namespace SiadMV.Manager.Models.Identity
{
    public class UserIdentityDto : IManagerContract, IManagerResponse
    {
        public Guid UserIdentityId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{FirstName} {Surname}";
        public string Phone { get; set; }
        public string CustomerSquareId { get; set; }
        public IList<UserAddressDto> Addresses { get; set; }
        public IList<UserProviderDto> Providers { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
