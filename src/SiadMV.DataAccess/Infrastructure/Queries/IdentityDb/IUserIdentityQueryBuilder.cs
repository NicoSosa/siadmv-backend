using SiadMV.DataAccess.Enums;
using SiadMV.DataAccess.Models.IdentityDb;
using EmpanadUS.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.IdentityDb
{
    public interface IUserIdentityQueryBuilder : IQueryBuilder<UserIdentity, IUserIdentityQueryBuilder>
    {
        IUserIdentityQueryBuilder FilterByEmail(string email);
        IUserIdentityQueryBuilder FilterById(Guid userIdentityId);
        IUserIdentityQueryBuilder FilterByUserProvider(UserProviderValue userProvider);
        IUserIdentityQueryBuilder IncludeProviders();
        IUserIdentityQueryBuilder IncludeAddresses();
        IUserIdentityQueryBuilder OrderByFullName();
    }
}
