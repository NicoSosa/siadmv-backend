using SiadMV.API.Enums;
using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.Identity
{
    public class GetUsersIdentitiesByUserProvider : QueryEnumerableBase<IEnumerable<UserIdentityViewModel>>
    {
        public UserProviderValue UserProvider { get; }

        public GetUsersIdentitiesByUserProvider(UserProviderValue userProvider)
        {
            UserProvider = userProvider;
        }
    }
}
