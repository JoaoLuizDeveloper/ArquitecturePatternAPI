using MediatR;

namespace ArquitecturePattern.Commands.CreateTransaction
{
    public record CreateTransactionCommand(string Description, decimal Amount) : IRequest<Guid>;
}
