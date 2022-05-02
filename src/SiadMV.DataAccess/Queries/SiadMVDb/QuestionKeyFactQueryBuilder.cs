using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;

namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class QuestionKeyFactQueryBuilder : SiadMVDbQueryBuilder<QuestionKeyFact, IQuestionKeyFactQueryBuilder>, IQuestionKeyFactQueryBuilder
    {
        public QuestionKeyFactQueryBuilder(SiadMVDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public IQuestionKeyFactQueryBuilder FilterByQuestionIdAsync(Guid questionId)
            => FilterBy(QuestionKeyFactExpressions.QFKByQuestionIdFilter(questionId));
        public IQuestionKeyFactQueryBuilder FilterByKeyFactIdAsync(Guid keyFactId)
            => FilterBy(QuestionKeyFactExpressions.QFKByKeyFactIdFilter(keyFactId));
        public IQuestionKeyFactQueryBuilder FilterByQuestionAndKeyFactIdAsync(Guid questionId, Guid keyFactId)
            => FilterBy(QuestionKeyFactExpressions.QKFByQuestionAndKeyFactIdFilter(questionId, keyFactId));
    }
}
