﻿using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.IdentityDb
{
    public interface IUserProviderQueryBuilder: IQueryBuilder<UserProvider, IUserProviderQueryBuilder>
    {
        IUserProviderQueryBuilder FilterByAuthUId(string authUId);
        IUserProviderQueryBuilder FilterByUserIdentityId(Guid userIdentityId);
    }
}
