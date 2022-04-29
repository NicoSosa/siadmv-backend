﻿using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Infrastructure.UnitOfWork;
using EmpanadUS.ServiceBase.DAL.Infrastructure.UnitOfWork;

namespace SiadMV.DataAccess.UnitOfWork
{
    public class SiadMVDbUoW : UnitOfWork<SiadMVDbContext>, ISiadMVDbUoW
    {
        public SiadMVDbUoW(SiadMVDbContext context)
            : base(context)
        {
        }
    }
}
