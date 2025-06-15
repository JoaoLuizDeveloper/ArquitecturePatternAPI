using ArquitecturePattern.Domain.Entities;
using MediatR;

namespace ArquitecturePattern.Commands.CreateTransaction
{
    // O handler executa a lógica de criação da transação.
    public class CreateTransactionHandler : IRequestHandler<CreateTransactionCommand, Guid>
    {
        private static readonly List<Transaction> _transactions = new(); // Simulação de banco

        // Recebe os dados de transação e cria uma nova.
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