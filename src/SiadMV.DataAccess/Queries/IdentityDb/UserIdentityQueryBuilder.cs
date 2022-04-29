using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Enums;
using SiadMV.DataAccess.Expressions.IdentityDb;
using SiadMV.DataAccess.Infrastructure.Queries.IdentityDb;
using SiadMV.DataAccess.Models.IdentityDb;
using EmpanadUS.ServiceBase.DAL.Infrastructure.Queries;
using System;
using System.Collections.Generic;

namespace SiadMV.DataAccess.Queries.IdentityDb
{
    public class UserIdentityQueryBuilder : IdentityDbQueryBuilder<UserIdentity, IUserIdentityQueryBuilder>, IUserIdentityQueryBuilder
    {
        public UserIdentityQueryBuilder(IdentityDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public IUserIdentityQueryBuilder FilterByEmail(string email)
            => FilterBy(UserIdentityExpressions.EmailFilter(email));
        public IUserIdentityQueryBuilder FilterById(Guid userIdentityId)
            => FilterBy(UserIdentityExpressions.UserIdentityIdFilter(userIdentityId));
        public IUserIdentityQueryBuilder FilterByUserProvider(UserProviderValue userProvider)
            => FilterBy(UserIdentityExpressions.UsersByProviderFilter(userProvider));
        public IUserIdentityQueryBuilder IncludeAddresses()
            => Include(u => u.Addresses);
        public IUserIdentityQueryBuilder IncludeProviders()
            => Include(u => u.Providers);

        public IUserIdentityQueryBuilder OrderByFullName()
        {
            var keySelectors = new List<OrderSelector<UserIdentity, object>>
            {
                new OrderSelector<UserIdentity, object> { Key = ui => ui.FirstName},
                new OrderSelector<UserIdentity, object> { Key = ui => ui.Surname}
            };

            return OrderByMany(keySelectors);
        }
    }
}
