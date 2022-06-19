using AutoMapper;
using SiadMV.API.Application.Commands.CommonExpression;
using SiadMV.API.Application.Queries.CommonExpression;
using SiadMV.API.Application.Requests.CommonExpression;
using SiadMV.API.Constants;
using SiadMV.API.Models.CommonExpression;
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
    public class CommonExpressionController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CommonExpressionController(
            IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));
            _mediator = mediator;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("{commonExpressionId}")]
        [ProducesResponseType(typeof(CommonExpressionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetCommonExpressionByIdAsync(Guid commonExpressionId)
        {
            var result = await _mediator.Send(new GetCommonExpressionByIdQuery(commonExpressionId));
            return Ok(result);
        }

        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(CommonExpressionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllCommonExpressionsAsync()
        {
            var result = await _mediator.Send(new GetAllCommonExpressionsQuery());
            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(CommonExpressionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> CreateCommonExpressionAsync([FromBody] AddCommonExpressionRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<AddCommonExpressionCommand>(request));
            return Ok(result);
        }

        [HttpPut]
        [Route("update")]
        [ProducesResponseType(typeof(CommonExpressionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> UpdateCommonExpressionAsync([FromBody] UpdateCommonExpressionRequest request)
        {
            var command = _mapper.Map<UpdateCommonExpressionCommand>(request);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("updateKeyFact")]
        [ProducesResponseType(typeof(CommonExpressionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> UpdateQuestionKeyFactAsync([FromBody] UpdateCommonExpressionKeyFactRequest request)
        {
            var command = _mapper.Map<UpdateCommonExpressionKeyFactCommand>(request);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
