using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface ICartQueryBuilder : IQueryBuilder<Cart, ICartQueryBuilder>
    {
        ICartQueryBuilder FilterById(Guid cartId);
        ICartQueryBuilder FilterByUserIdentityId(Guid userIdentityId);
        ICartQueryBuilder IncludeCartProducts();
    }
}
