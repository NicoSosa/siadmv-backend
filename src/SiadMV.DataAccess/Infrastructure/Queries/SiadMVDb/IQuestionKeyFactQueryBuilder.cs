using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.ServiceBase.DAL.SeedWork;
using System;

namespace SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb
{
    public interface IQuestionKeyFactQueryBuilder : IQueryBuilder<QuestionKeyFact, IQuestionKeyFactQueryBuilder>
    {
        IQuestionKeyFactQueryBuilder FilterByQuestionIdAsync(Guid questionId);
        IQuestionKeyFactQueryBuilder FilterByKeyFactIdAsync(Guid keyFactId);
        IQuestionKeyFactQueryBuilder FilterByQuestionAndKeyFactIdAsync(Guid questionId, Guid keyFactId);
    }
}
