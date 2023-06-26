using AutoMapper;
using DomainDrivenDesignPOC.Api.Model.Response;
using DomainDrivenDesignPOC.Business.MediatR.Queries.CompanyQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace DomainDrivenDesignPOC.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyQueryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CompanyQueryController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(typeof(IList<ApiResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateCompanyAsync(CancellationToken cancellationToken)
        {
            return Ok(_mapper.Map<>(await _mediator.Send(new GetAllCompaniesQuery(), cancellationToken)));

        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<Companies>), StatusCodes.Status200OK)]
        public async Task<IActionResult> CompanyListAsync(CancellationToken cancellationToken)
        {
            return Ok(_mapper.Map<IList<Companies>>(await _mediator.Send(new GetAllCompaniesQuery(), cancellationToken)));

        }
    }
}
