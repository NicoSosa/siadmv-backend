using SiadMV.API.Models.KeyFact;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.KeyFact
{
    public class GetAllKeysFactQuery : QueryEnumerableBase<IEnumerable<KeyFactViewModel>>
    {
    }
}
