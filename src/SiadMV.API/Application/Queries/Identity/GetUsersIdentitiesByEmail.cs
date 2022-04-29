using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.Identity
{
    public class GetUsersIdentitiesByEmail : QueryEnumerableBase<IEnumerable<UserIdentityViewModel>>
    {
        public string Email { get; }

        public GetUsersIdentitiesByEmail(string email)
        {
            Email = email;
        }
    }
}
