using ArquitecturePattern.Commands.CreateTransaction;
using ArquitecturePattern.Domain.Entities;
using MediatR;

namespace ArquitecturePattern.Queries.GetTransactions
{
    public class GetAllTransactionsHandler : IRequestHandler<GetAllTransactionsQuery, IEnumerable<Transaction>>
    {
        // O handler executa a lógica para obter a lista das transações.
        public Task<IEnumerable<Transaction>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            var list = CreateTransactionHandler.GetData();
            return Task.FromResult(list.AsEnumerable());
        }
    }
}