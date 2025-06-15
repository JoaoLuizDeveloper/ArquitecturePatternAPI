namespace ArquitecturePattern.Domain.Entities
{
    // A entidade Transaction representa uma transação financeira.
    public class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}