using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public static class QuestionKeyFactExpressions
    {
        public static Expression<Func<QuestionKeyFact, bool>> QFKByQuestionIdFilter(Guid questionId)
            => PredicateBuilder.New<QuestionKeyFact>().And(qkf => qkf.QuestionId == questionId);
        public static Expression<Func<QuestionKeyFact, bool>> QFKByKeyFactIdFilter(Guid keyFactId)
            => PredicateBuilder.New<QuestionKeyFact>().And(qkf => qkf.KeyFactId == keyFactId);

        public static Expression<Func<QuestionKeyFact, bool>> QKFByQuestionAndKeyFactIdFilter(Guid questionId, Guid keyFactId)
            => PredicateBuilder.New<QuestionKeyFact>().And(qkf => qkf.QuestionId == questionId && qkf.KeyFactId == keyFactId);
    }
}