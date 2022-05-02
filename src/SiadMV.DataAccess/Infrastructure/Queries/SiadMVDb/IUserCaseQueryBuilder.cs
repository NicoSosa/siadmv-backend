using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface IUserCaseQueryBuilder : IQueryBuilder<UserCase, IUserCaseQueryBuilder>
    {
        IUserCaseQueryBuilder FilterByUserCaseIdAsync(Guid userCaseId);
    }
}
