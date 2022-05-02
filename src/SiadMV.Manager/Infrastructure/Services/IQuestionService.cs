using SiadMV.Manager.Models.Question;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiadMV.Manager.Infrastructure.Services
{
    public interface IQuestionService
    {
        Task<IEnumerable<QuestionDto>> GetQuestionsAsync();
        Task<QuestionDto> GetQuestionByIdAsync(Guid questionId);
        Task<QuestionDto> CreateQuestionAsync(CreateQuestionDto createQuestionDto);
        Task<QuestionDto> UpdateQuestionAsync(UpdateQuestionDto updateQuestionDto);
        //Task<QuestionDto> RelateKeysFactListToQuestionAsync(RelateKeysFactListToQuestionDto relateKeysFactListToQuestionDto);
    }
}
