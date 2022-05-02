using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface IQuestionQueryBuilder : IQueryBuilder<Question, IQuestionQueryBuilder>
    {
        IQuestionQueryBuilder FilterByQuestionIdAsync(Guid questionId);
        IQuestionQueryBuilder IncludeKeysFact();
    }
}
