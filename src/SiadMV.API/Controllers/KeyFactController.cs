using AutoMapper;
using SiadMV.API.Application.Commands.KeyFact;
using SiadMV.API.Application.Queries.KeyFact;
using SiadMV.API.Application.Requests.KeyFact;
using SiadMV.API.Constants;
using SiadMV.API.Models.KeyFact;
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
    public class KeyFactController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public KeyFactController(IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{keyFactId}")]
        [ProducesResponseType(typeof(KeyFactViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetKeyFactById(Guid keyFactId)
        {
            var result = await _mediator.Send(new GetKeyFactByIdQuery(keyFactId));
            return Ok(result);
        }

        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(KeyFactViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllQuestions()
        {
            var result = await _mediator.Send(new GetAllKeysFactQuery());
            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(KeyFactViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> CreateKeyFactAsync([FromBody] AddKeyFactRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<AddKeyFactCommand>(request));
            return Ok(result);
        }


        [HttpPut]
        [Route("update")]
        [ProducesResponseType(typeof(KeyFactViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> UpdateKeyFactAsync([FromBody] UpdateKeyFactRequest request)
        {
            var command = _mapper.Map<UpdateKeyFactCommand>(request);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
