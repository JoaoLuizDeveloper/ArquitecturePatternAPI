using ArquitecturePattern.Commands.CreateTransaction;
using ArquitecturePattern.Queries.GetTransactions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArquitecturePattern.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TransactionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTransactionCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllTransactionsQuery());
            return Ok(result);
        }
    }
}
