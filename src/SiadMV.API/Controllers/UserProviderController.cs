using AutoMapper;
using SiadMV.API.Application.Commands.Identity;
using SiadMV.API.Application.Queries.Identity;
using SiadMV.API.Application.Requests.Identity;
using SiadMV.API.Constants;
using SiadMV.API.Models;
using SiadMV.API.Models.Identity;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MediatR;
using MGK.Acceptance;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;


namespace SiadMV.API.Controllers
{
    [Route(CoreConstants.IdentityPath + "[controller]")]
    [ApiController]
    public class UserProviderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserProviderController(IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("add")]
        [ProducesResponseType(typeof(UserProviderViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> AddUserProviderAsync([FromBody] AddUserProviderRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<AddUserProviderCommand>(request));
            return Ok(result);
        }

        [HttpGet]
        [Route("{authUId}")]
        [ProducesResponseType(typeof(UserProviderViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUserProviderByAuthUId(string authUId)
        {
            var result = await _mediator.Send(new GetUserProviderQuery(authUId));
            return Ok(result);
        }

        [HttpGet]
        [Route("byUserId/{userIdentityId}")]
        [ProducesResponseType(typeof(IEnumerable<UserProviderViewModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUserProvidersByUserIdentityId(Guid userIdentityId)
        {
            var results = await _mediator.Send(new GetUserProvidersByUserIdentityIdQuery(userIdentityId));
            return Ok(results);
        }

        [HttpDelete]
        [Route("{authUId}")]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> RemoveUserProviderAsync(string authUId)
        {
            var result = await _mediator.Send(new RemoveUserProviderCommand(authUId));
            return Ok(result);
        }
    }
}
