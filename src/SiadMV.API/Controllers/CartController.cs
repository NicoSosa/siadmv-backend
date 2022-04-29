using AutoMapper;
using SiadMV.API.Application.Commands.Cart;
using SiadMV.API.Application.Queries.Cart;
using SiadMV.API.Application.Requests.Cart;
using SiadMV.API.Constants;
using SiadMV.API.Models.Cart;
using SiadMV.ServiceBase.Infrastructure.Exceptions;
using MediatR;
using MGK.Acceptance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiadMV.API.Controllers
{
    [Route(CoreConstants.ContextPath + "[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CartController(IMediator mediator, IMapper mapper)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));

            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("refresh")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(CartViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.Conflict)]
        public async Task<IActionResult> UpsertCartAsync([FromBody] UpsertCartRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<UpsertCartCommand>(request));
            return Ok(result);
        }

        [HttpGet]
        [Route("{cartId}")]
        [ProducesResponseType(typeof(CartViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetCartByIdAsync(Guid cartId)
        {
            var result = await _mediator.Send(new GetCartByIdQuery(cartId));
            return Ok(result);
        }
        
        [HttpGet]
        [Route("user/{userId}")]
        [ProducesResponseType(typeof(CartViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetCartByUserIdentityIdAsync(Guid userId)
        {
            var result = await _mediator.Send(new GetCartByUserIdentityIdQuery(userId));
            return Ok(result);
        }
    }
}
