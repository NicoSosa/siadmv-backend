using AutoMapper;
using SiadMV.API.Application.Commands.Identity;
using SiadMV.API.Application.Queries.Identity;
using SiadMV.API.Application.Requests.Identity;
using SiadMV.API.Constants;
using SiadMV.API.Enums;
using SiadMV.API.Models;
using SiadMV.API.Models.Identity;
using EmpanadUS.ServiceBase.Infrastructure.Exceptions;
using MediatR;
using MGK.Acceptance;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;


namespace SiadMV.API.Controllers
{
    [Route(CoreConstants.IdentityPath + "[controller]")]
    [ApiController]
    public class UserIdentityController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserIdentityController(IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Create a new User
        /// </summary>
        /// <response code="200">User Created Correctly</response>
        /// <response code="400">Bad request</response>
        /// <remarks> 
        /// All properties are required except Address <br/> <br/>
        /// UserProvider <br/>
        /// 0 = User No Authenticated <br/>
        /// 1 = User Authenticated by Multiple Provider <br/>
        /// 2 = Anonymously Authenticated <br/>
        /// 3 = Authenticated by Google <br/>
        /// 4 = Authenticated by Facebook <br/>
        /// 5 = Authenticated by Apple <br/> <br/>
        /// </remarks>
        [HttpPost]
        [Route("add")]
        [ProducesResponseType(typeof(UserIdentityViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> AddUserIdentityAsync([FromBody] AddUserIdentityRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<AddUserIdentityCommand>(request));
            return Ok(result);
        }

        [HttpGet]
        [Route("{userIdentityId}")]
        [ProducesResponseType(typeof(UserIdentityViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUserIdentityAsync(Guid userIdentityId)
        {
            var result = await _mediator.Send(new GetUserIdentityQuery(userIdentityId));
            return Ok(result);
        }

        [HttpGet]
        [Route("byEmail/{email}")]
        [ProducesResponseType(typeof(UserIdentityViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUsersIdentitiesByEmailAsync(string email)
        {
            var result = await _mediator.Send(new GetUsersIdentitiesByEmail(email));
            return Ok(result);
        }


        /// <summary>
        /// Get All Users for specified Provider
        /// </summary>
        /// <remarks> 
        /// UserProvider <br/>
        /// 0 = User No Authenticated <br/>
        /// 1 = User Authenticated by Multiple Provider <br/>
        /// 2 = Anonymously Authenticated <br/>
        /// 3 = Authenticated by Google <br/>
        /// 4 = Authenticated by Facebook <br/>
        /// 5 = Authenticated by Apple <br/> <br/>
        /// </remarks>
        [HttpGet]
        [Route("byUserProvider/{userProvider}")]
        [ProducesResponseType(typeof(UserIdentityViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUsersIdentitiesByTypeSession(UserProviderValue userProvider)
        {
            var result = await _mediator.Send(new GetUsersIdentitiesByUserProvider(userProvider));
            return Ok(result);
        }

        [HttpDelete]
        [Route("{userIdentityId}")]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> RemoveUserIdentityAsync(Guid userIdentityId)
        {
            var result = await _mediator.Send(new RemoveUserIdentityCommand(userIdentityId));
            return Ok(result);
        }

        [HttpPut]
        [Route("{userIdentityId}")]
        [ProducesResponseType(typeof(UserIdentityViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateUserIdentityAsync(Guid userIdentityId, [FromBody] UpdateUserIdentityRequest request)
        {
            var command = _mapper.Map<UpdateUserIdentityCommand>(request);
            command.UserIdentityId = userIdentityId;
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
