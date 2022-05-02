using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.Queries;
using System.Collections.Generic;

namespace SiadMV.API.Application.Queries.Question
{
    public class GetAllQuestionsQuery : QueryEnumerableBase<IEnumerable<QuestionViewModel>>
    {
    }
}
