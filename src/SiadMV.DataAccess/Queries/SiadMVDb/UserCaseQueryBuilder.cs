using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;
using System.Linq;

namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class UserCaseQueryBuilder : SiadMVDbQueryBuilder<UserCase, IUserCaseQueryBuilder>, IUserCaseQueryBuilder
    {
        public UserCaseQueryBuilder(SiadMVDbContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        public IUserCaseQueryBuilder FilterByUserCaseIdAsync(Guid userCaseId)
            => FilterBy(UserCaseExpressions.UserCaseIdFilter(userCaseId));
    }
}
