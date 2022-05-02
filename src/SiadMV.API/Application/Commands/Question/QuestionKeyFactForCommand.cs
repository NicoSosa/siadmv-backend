using System;
using System.Collections.Generic;
using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.CQRS.Commands;

namespace SiadMV.API.Application.Commands.Question
{
    public class QuestionKeyFactForCommand
    {
        public Guid KeyFactId { get; set; }
    }
}
