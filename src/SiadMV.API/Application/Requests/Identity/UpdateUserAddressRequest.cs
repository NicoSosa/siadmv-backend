using SiadMV.API.Enums;
using MediatR;
using System;

namespace SiadMV.API.Application.Requests.Identity
{
    public class UpdateUserAddressRequest : IRequest
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public AddressType AddressType { get; set; }
    }
}
