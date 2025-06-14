using ArquitecturePattern.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace ArquitecturePattern.Queries.GetTransactions
{
    public record GetAllTransactionsQuery() : IRequest<IEnumerable<Transaction>>;
}
