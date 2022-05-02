using SiadMV.API.Models.KeyFact;
using SiadMV.ServiceBase.CQRS.Queries;
using System;


namespace SiadMV.API.Application.Queries.KeyFact
{
    public class GetKeyFactByIdQuery : QueryBase<KeyFactViewModel>
    {
        public Guid KeyFactId { get; }

        public GetKeyFactByIdQuery(Guid keyFactId)
        {
            KeyFactId = keyFactId;
        }
    }
}
