using SiadMV.API.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.UserCase
{
    public class GetAllUserCaseQuery : QueryEnumerableBase<IEnumerable<UserCaseViewModel>>
    {
    }
}
