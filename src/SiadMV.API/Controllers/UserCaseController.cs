using AutoMapper;
//using SiadMV.API.Application.Commands.UserCase;
using SiadMV.API.Application.Queries.UserCase;
//using SiadMV.API.Application.Requests.UserCase;
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
    [Route(CoreConstants.IdentityPath + "[controller]")]
    [ApiController]
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
        [AllowAnonymous]
        [ProducesResponseType(typeof(UserCaseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetUserCaseById(Guid userCaseId)
        {
            var result = await _mediator.Send(new GetUserCaseByIdQuery(userCaseId));
            return Ok(result);
        }
        
        [HttpGet]
        [Route("random")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(UserCaseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetRandomUserCase()
        {
            var result = await _mediator.Send(new GetRandomUserCaseQuery());
            return Ok(result);
        }
    }
}
