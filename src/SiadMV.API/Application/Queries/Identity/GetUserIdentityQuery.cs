using SiadMV.API.Models.Identity;
using EmpanadUS.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.Identity
{
    public class GetUserIdentityQuery : QueryBase<UserIdentityViewModel>
    {
        public Guid UserIdentityId { get; }

        public GetUserIdentityQuery(Guid userIdentityId)
        {
            UserIdentityId = userIdentityId;
        }
    }
}
