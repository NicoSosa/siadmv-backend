using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.IdentityDb;
using SiadMV.DataAccess.Infrastructure.Queries.IdentityDb;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Queries.IdentityDb
{
    public class UserProviderQueryBuilder: IdentityDbQueryBuilder<UserProvider, IUserProviderQueryBuilder>, IUserProviderQueryBuilder
    {
        public UserProviderQueryBuilder(IdentityDbContext context, IMapper mapper)
            : base (context, mapper)
        {
        }
        public IUserProviderQueryBuilder FilterByAuthUId(string authUId)
            => FilterBy(UserProviderExpressions.ProviderByAuthUIdFilter(authUId));
        public IUserProviderQueryBuilder FilterByUserIdentityId(Guid userIdentityId)
            => FilterBy(UserProviderExpressions.ProvidersByUserIdentityIdFilter(userIdentityId));
    }
}
