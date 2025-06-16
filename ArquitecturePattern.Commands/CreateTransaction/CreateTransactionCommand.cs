using MediatR;

namespace ArquitecturePattern.Commands.CreateTransaction
{
    // The Command is intended to create the transaction with the necessary data
    public record CreateTransactionCommand(string Description, decimal Amount) : IRequest<Guid>;
}
