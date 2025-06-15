using MediatR;

namespace ArquitecturePattern.Commands.CreateTransaction
{
    // O Command tem a intenção de criar a transação, com os dados necessários.
    public record CreateTransactionCommand(string Description, decimal Amount) : IRequest<Guid>;
}
