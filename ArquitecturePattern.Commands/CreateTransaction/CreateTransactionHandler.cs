using ArquitecturePattern.Domain.Entities;
using MediatR;

namespace ArquitecturePattern.Commands.CreateTransaction
{
    // The handler executes the logic for creating the transaction
    public class CreateTransactionHandler : IRequestHandler<CreateTransactionCommand, Guid>
    {
        private static readonly List<Transaction> _transactions = new(); // Simulação de banco

        // Receives the transaction data and creates a new one
        public Task<Guid> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            var transaction = new Transaction
            {
                Description = request.Description,
                Amount = request.Amount
            };

            _transactions.Add(transaction);
            return Task.FromResult(transaction.Id);
        }

        public static List<Transaction> GetData() => _transactions;
    }
}