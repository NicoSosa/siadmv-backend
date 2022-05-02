using AutoMapper;
using SiadMV.DataAccess.Contexts;
using SiadMV.DataAccess.Expressions.SiadMVDb;
using SiadMV.DataAccess.Infrastructure.Queries.SiadMVDb;
using SiadMV.DataAccess.Models.SiadMVDb;
using System;

namespace SiadMV.DataAccess.Queries.SiadMVDb
{
    public class QuestionQueryBuilder : SiadMVDbQueryBuilder<Question, IQuestionQueryBuilder>, IQuestionQueryBuilder
    {
        public QuestionQueryBuilder(SiadMVDbContext context, IMapper mapper)
            : base(context, mapper)
        { 
        }

        public IQuestionQueryBuilder FilterByQuestionIdAsync(Guid questionId)
            => FilterBy(QuestionExpressions.QuestionIdFilter(questionId));
        public IQuestionQueryBuilder IncludeKeysFact()
            => Include(q => q.KeysFact);
    }
}
