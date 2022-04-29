using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Queries;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.Identity
{
    public class GetUserAddressesByUserIdentityIdQuery : QueryEnumerableBase<IEnumerable<UserAddressViewModel>>
    {
        public Guid UserIdentityId { get; }

        public GetUserAddressesByUserIdentityIdQuery(Guid userIdentityId)
        {
            UserIdentityId = userIdentityId;
        }
    }
}
