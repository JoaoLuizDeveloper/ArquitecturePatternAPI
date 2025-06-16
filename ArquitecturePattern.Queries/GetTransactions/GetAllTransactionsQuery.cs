using ArquitecturePattern.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace ArquitecturePattern.Queries.GetTransactions
{
    // The Query is intended to retrieve the transactions
    public record GetAllTransactionsQuery() : IRequest<IEnumerable<Transaction>>;
}
