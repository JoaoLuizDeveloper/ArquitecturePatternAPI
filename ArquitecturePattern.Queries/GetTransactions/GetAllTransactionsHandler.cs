using ArquitecturePattern.Commands.CreateTransaction;
using ArquitecturePattern.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace ArquitecturePattern.Queries.GetTransactions
{
    public class GetAllTransactionsHandler : IRequestHandler<GetAllTransactionsQuery, IEnumerable<Transaction>>
    {
        public Task<IEnumerable<Transaction>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            var list = CreateTransactionHandler.GetData(); // Simula leitura
            return Task.FromResult(list.AsEnumerable());
        }
    }
}
