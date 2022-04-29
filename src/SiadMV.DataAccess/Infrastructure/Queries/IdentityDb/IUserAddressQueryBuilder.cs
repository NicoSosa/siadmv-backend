using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.IdentityDb
{
    public interface IUserAddressQueryBuilder : IQueryBuilder<UserAddress, IUserAddressQueryBuilder>
    {
        IUserAddressQueryBuilder FilterById(Guid addressId);
        IUserAddressQueryBuilder FilterByUserIdentityId(Guid userIdentityId);
        //IUserAddressQueryBuilder FilterBillingAddressByUserIdentityId(Guid userIdentityId);
        IUserAddressQueryBuilder FilterByZipcode(string zipcode);
    }
}
