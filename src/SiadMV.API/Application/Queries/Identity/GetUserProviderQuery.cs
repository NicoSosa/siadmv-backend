using SiadMV.API.Models.Identity;
using EmpanadUS.ServiceBase.CQRS.Queries;

namespace SiadMV.API.Application.Queries.Identity
{
    public class GetUserProviderQuery: QueryBase<UserProviderViewModel>
    {
        public string AuthUId { get; }
        public GetUserProviderQuery(string authUId)
        {
            AuthUId = authUId;
        }
    }
}
