using SiadMV.ServiceBase.CQRS.SeedWork;
using System;

namespace SiadMV.API.Infrastructure.Contracts.Question
{
    public interface IQuestionKeyFactContract : IContract
    {
        public Guid KeyFactId { get; }
        public Guid QuestionId { get; }
    }
}
