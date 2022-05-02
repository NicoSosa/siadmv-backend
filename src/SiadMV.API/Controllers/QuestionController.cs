using AutoMapper;
using SiadMV.API.Application.Commands.Question;
using SiadMV.API.Application.Queries.Question;
using SiadMV.API.Application.Requests.Question;
using SiadMV.API.Constants;
using SiadMV.API.Models.Question;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MediatR;
using MGK.Acceptance;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace SiadMV.API.Controllers
{
    [Route(CoreConstants.ContextPath + "[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class QuestionController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public QuestionController(IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{questionId}")]
        [ProducesResponseType(typeof(QuestionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetQuestionByIdAsync(Guid questionId)
        {
            var result = await _mediator.Send(new GetQuestionByIdQuery(questionId));
            return Ok(result);
        }

        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(QuestionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllQuestionsAsync()
        {
            var result = await _mediator.Send(new GetAllQuestionsQuery());
            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(QuestionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> CreateUserCaseAsync([FromBody] AddQuestionRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<AddQuestionCommand>(request));
            return Ok(result);
        }


        [HttpPut]
        [Route("update")]
        [ProducesResponseType(typeof(QuestionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> UpdateQuestionAsync([FromBody] UpdateQuestionRequest request)
        {
            var command = _mapper.Map<UpdateQuestionCommand>(request);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("updateKeyFact")]
        [ProducesResponseType(typeof(QuestionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> UpdateQuestionKeyFactAsync([FromBody] UpdateQuestionKeyFactRequest request)
        {
            var command = _mapper.Map<UpdateQuestionKeyFactCommand>(request);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
