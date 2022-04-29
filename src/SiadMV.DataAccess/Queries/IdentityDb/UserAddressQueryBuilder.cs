using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.IdentityDb;
using SiadMV.DataAccess.Infrastructure.Queries.IdentityDb;
using SiadMV.DataAccess.Models.IdentityDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Queries.IdentityDb
{
    public class UserAddressQueryBuilder : IdentityDbQueryBuilder<UserAddress, IUserAddressQueryBuilder>, IUserAddressQueryBuilder
    {
        public UserAddressQueryBuilder(IdentityDbContext context, IMapper mapper)
            : base (context, mapper)
        {
        }
        public IUserAddressQueryBuilder FilterById(Guid addressId)
            => FilterBy(UserAddressExpressions.AddressByIdFilter(addressId));
        public IUserAddressQueryBuilder FilterByUserIdentityId(Guid userIdentityId)
            => FilterBy(UserAddressExpressions.AddressByUserIdentityIdFilter(userIdentityId));
        //public IUserAddressQueryBuilder FilterBillingAddressByUserIdentityId(Guid userIdentityId)
        //    => FilterBy(UserAddressExpressions.BillingAddressByIdFilter(userIdentityId));
        public IUserAddressQueryBuilder FilterByZipcode(string zipcode)
            => FilterBy(UserAddressExpressions.AddressByZipcode(zipcode));
    }
}
