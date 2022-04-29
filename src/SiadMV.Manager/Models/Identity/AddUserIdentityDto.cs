using SiadMV.Manager.Enums;
using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.Identity
{
    public class AddUserIdentityDto : IManagerContract
    {
        public Guid UserIdentityId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string CustomerSquareId { get; set; }
        public UserAddressDto Address { get; set; }
        public UserProviderDto Provider { get; set; }
    }
}
