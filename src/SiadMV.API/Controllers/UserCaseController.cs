using AutoMapper;
using SiadMV.API.Application.Commands.UserCase;
using SiadMV.API.Application.Queries.UserCase;
using SiadMV.API.Application.Requests.UserCase;
using SiadMV.API.Constants;
using SiadMV.API.Models.UserCase;
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
    public class UserCaseController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserCaseController(IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{userCaseId}")]
        [ProducesResponseType(typeof(UserCaseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetUserCaseByIdAsync(Guid userCaseId)
        {
            var result = await _mediator.Send(new GetUserCaseByIdQuery(userCaseId));
            return Ok(result);
        }
        
        [HttpGet]
        [Route("random")]
        [ProducesResponseType(typeof(UserCaseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetRandomUserCaseAsync()
        {
            var result = await _mediator.Send(new GetRandomUserCaseQuery());
            return Ok(result);
        }
        
        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(UserCaseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllUserCasesAsync()
        {
            var result = await _mediator.Send(new GetAllUserCaseQuery());
            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(UserCaseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> CreateUserCaseAsync([FromBody] AddUserCaseRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<AddUserCaseCommand>(request));
            return Ok(result);
        }


        [HttpPut]
        [Route("update")]
        [ProducesResponseType(typeof(UserCaseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> UpdateUserCaseAsync([FromBody] UpdateUserCaseRequest request)
        {
            var command = _mapper.Map<UpdateUserCaseCommand>(request);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
