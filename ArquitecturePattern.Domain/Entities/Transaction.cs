namespace ArquitecturePattern.Domain.Entities
{
    // The Transaction entity represents a financial transaction
    public class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}