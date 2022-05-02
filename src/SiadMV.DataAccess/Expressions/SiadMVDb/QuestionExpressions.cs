using SiadMV.DataAccess.Models.SiadMVDb;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace SiadMV.DataAccess.Expressions.SiadMVDb
{
    public static class QuestionExpressions
    {
        public static Expression<Func<Question, bool>> QuestionIdFilter(Guid questionId)
            => PredicateBuilder.New<Question>().And(q => q.Id == questionId);
    }
}
