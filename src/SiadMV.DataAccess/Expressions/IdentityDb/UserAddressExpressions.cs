using SiadMV.DataAccess.Enums;
using SiadMV.DataAccess.Models.IdentityDb;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SiadMV.DataAccess.Expressions.IdentityDb
{
    public static class UserAddressExpressions
    {
        public static Expression<Func<UserAddress, bool>> AddressByIdFilter(Guid addressId)
            => PredicateBuilder.New<UserAddress>().And(ua => ua.Id == addressId);

        public static Expression<Func<UserAddress, bool>> AddressByUserIdentityIdFilter(Guid userIdentityId)
           => PredicateBuilder.New<UserAddress>().And(ua => ua.UserIdentityId == userIdentityId);

        public static Expression<Func<UserAddress, bool>> AddressByZipcode(string zipcode)
            => PredicateBuilder.New<UserAddress>().And(ua => ua.Zipcode == zipcode);
        //public static Expression<Func<UserAddress, bool>> BillingAddressByIdFilter(Guid addressId)
        //    => PredicateBuilder.New<UserAddress>().And(ua => ua.Id == addressId && ua.AddressType == AddressType.Billing);
        //=> PredicateBuilder.New<UserAddress>().And(ua => ua.Id == addressId && ua.AddressType == AddressType.Billing);
    }
}
