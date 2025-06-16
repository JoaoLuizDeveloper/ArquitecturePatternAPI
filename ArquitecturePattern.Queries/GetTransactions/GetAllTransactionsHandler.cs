using ArquitecturePattern.Commands.CreateTransaction;
using ArquitecturePattern.Domain.Entities;
using MediatR;

namespace ArquitecturePattern.Queries.GetTransactions
{
    public class GetAllTransactionsHandler : IRequestHandler<GetAllTransactionsQuery, IEnumerable<Transaction>>
    {
        // The handler executes the logic to retrieve the list of transactions
        public Task<IEnumerable<Transaction>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            var list = CreateTransactionHandler.GetData();
            return Task.FromResult(list.AsEnumerable());
        }
    }
}