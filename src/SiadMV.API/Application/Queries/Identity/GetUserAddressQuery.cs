using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.Identity
{
    public class GetUserAddressQuery : QueryBase<UserAddressViewModel>
    {
        public Guid UserAddressId { get; }

        public GetUserAddressQuery(Guid userAddressId)
        {
            UserAddressId = userAddressId;
        }
    }
}
