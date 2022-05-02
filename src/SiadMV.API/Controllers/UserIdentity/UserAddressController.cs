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
    [ApiExplorerSettings(GroupName = "Custom Group Name")]

    public class UserAddressController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserAddressController(IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("add")]
        [ProducesResponseType(typeof(UserAddressViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> AddUserAddressAsync([FromBody] AddUserAddressRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<AddUserAddressCommand>(request));
            return Ok(result);
        }

        [HttpGet]
        [Route("{userAddressId}")]
        [ProducesResponseType(typeof(UserAddressViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUserAddressById(Guid userAddressId)
        {
            var result = await _mediator.Send(new GetUserAddressQuery(userAddressId));
            return Ok(result);
        }

        [HttpGet]
        [Route("byUserId/{userIdentityId}")]
        [ProducesResponseType(typeof(IEnumerable<UserAddressViewModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUserAddressesByUserIdentityId(Guid userIdentityId)
        {
            var results = await _mediator.Send(new GetUserAddressesByUserIdentityIdQuery(userIdentityId));
            return Ok(results);
        }

        [HttpDelete]
        [Route("{userAddressId}")]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> RemoveUserAddressAsync(Guid userAddressId)
        {
            var result = await _mediator.Send(new RemoveUserAddressCommand(userAddressId));
            return Ok(result);
        }

        [HttpPut]
        [Route("{userAddressId}")]
        [ProducesResponseType(typeof(UserAddressViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateUserAddressAsync(Guid userAddressId, [FromBody] UpdateUserAddressRequest request)
        {
            var command = _mapper.Map<UpdateUserAddressCommand>(request);
            command.UserAddressId = userAddressId;
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
