using SiadMV.DataAccess.Models.SiadMVDb;
using EmpanadUS.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface ICartProductQueryBuilder : IQueryBuilder<CartProduct, ICartProductQueryBuilder>
    {
        ICartProductQueryBuilder FilterByCartIdAsync(Guid cartId);
    }
}
