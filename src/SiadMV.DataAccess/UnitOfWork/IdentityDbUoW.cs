using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using SiadMV.ServiceBase.DAL.Infrastructure.UnitOfWork;

namespace SiadMV.DataAccess.UnitOfWork
{
    public class IdentityDbUoW : UnitOfWork<IdentityDbContext>, IIdentityDbUoW
    {
        public IdentityDbUoW(IdentityDbContext context)
            :base (context)
        {
        }
    }
}
