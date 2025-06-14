using ArquitecturePattern.Domain.Entities;
using MediatR;

namespace ArquitecturePattern.Commands.CreateTransaction
{
    public class CreateTransactionHandler : IRequestHandler<CreateTransactionCommand, Guid>
    {
        private static readonly List<Transaction> _transactions = new(); // Simulação de banco

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

        // ⚠️ Em produção, injete um repositório aqui em vez de lista estática.
        public static List<Transaction> GetData() => _transactions;
    }
}