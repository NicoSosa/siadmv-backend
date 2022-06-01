using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface ICommonExpressionKeyFactQueryBuilder : IQueryBuilder<CommonExpressionKeyFact, ICommonExpressionKeyFactQueryBuilder>
    {
        ICommonExpressionKeyFactQueryBuilder FilterByCommonExpressionIdAsync(Guid commonExpressionId);
        ICommonExpressionKeyFactQueryBuilder FilterByKeyFactIdAsync(Guid keyFactId);
        ICommonExpressionKeyFactQueryBuilder FilterByCommonExpressionKeyFactIdAsync(Guid commonExpressionId, Guid keyFactId);
    }
}
