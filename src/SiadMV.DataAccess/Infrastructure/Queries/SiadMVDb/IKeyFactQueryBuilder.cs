using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface IKeyFactQueryBuilder : IQueryBuilder<KeyFact, IKeyFactQueryBuilder>
    {
        IKeyFactQueryBuilder FilterByKeyFactIdAsync(Guid keyFactId);
        IKeyFactQueryBuilder IncludeQuestions();
    }
}
