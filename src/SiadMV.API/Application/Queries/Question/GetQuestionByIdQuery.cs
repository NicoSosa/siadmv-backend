using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.Question
{
    public class GetQuestionByIdQuery : QueryBase<QuestionViewModel>
    {
        public Guid QuestionId { get; }

        public GetQuestionByIdQuery(Guid questionId)
        {
            QuestionId = questionId;
        }
    }
}
