using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface ICommonExpressionQueryBuilder : IQueryBuilder<CommonExpression, ICommonExpressionQueryBuilder>
    {
        ICommonExpressionQueryBuilder FilterByCommonExpressionIdAsync(Guid commonExpressionId);
        ICommonExpressionQueryBuilder IncludeKeysFact();
    }
}
