using Application.Base;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Base_28_10_2021.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name, CancellationToken cancellationToken)
        {
            var dto = await _mediator.Send(new GetQuery(name), cancellationToken);
            return Ok(dto);
        }
    }
}
