using ArquitecturePattern.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace ArquitecturePattern.Queries.GetTransactions
{
    // O Query deseja obter as transações.
    public record GetAllTransactionsQuery() : IRequest<IEnumerable<Transaction>>;
}
