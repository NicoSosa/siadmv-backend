using SiadMV.API.Enums;

namespace SiadMV.API.Application.Commands.Identity
{
    public class UserAddressForCommand
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public AddressType AddressType { get; set; }
    }
}
