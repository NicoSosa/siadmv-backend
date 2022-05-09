using AutoMapper;
//using SiadMV.API.Application.Commands.Question;
//using SiadMV.API.Application.Queries.Question;
//using SiadMV.API.Application.Requests.Question;
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

using SiadMV.Manager.Infrastructure.Services.Python;
using SiadMV.API.Models;

namespace SiadMV.API.Controllers
{
    [Route(CoreConstants.ContextPath + "[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TestController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IPythonService _pythonService;

        public TestController(IMediator mediator, IMapper mapper, IPythonService pythonService)
        {
            Ensure.Parameter.IsNotNull(mediator, nameof(mediator));
            Ensure.Parameter.IsNotNull(mapper, nameof(mapper));
            Ensure.Parameter.IsNotNull(pythonService, nameof(pythonService));

            _mediator = mediator;
            _mapper = mapper;
            _pythonService = pythonService;
        }

        [HttpGet]
        [Route("test")]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> TestPythonScript()
        {
            var pyServiceData = await _pythonService.TestScriptAsync();
            var result = new ResponseViewModel
            {
                Message = pyServiceData
            };

            return Ok(result);
        }
    }
}
