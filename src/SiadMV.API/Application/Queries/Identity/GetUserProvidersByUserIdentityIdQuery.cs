using SiadMV.API.Models.Identity;
using EmpanadUS.ServiceBase.CQRS.Queries;
using System;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.Identity
{
    public class GetUserProvidersByUserIdentityIdQuery: QueryEnumerableBase<IEnumerable<UserProviderViewModel>>
    {
        public Guid UserIdentityId { get; }
        public GetUserProvidersByUserIdentityIdQuery(Guid userIdentityId)
        {
            UserIdentityId = userIdentityId;
        }
    }
}
