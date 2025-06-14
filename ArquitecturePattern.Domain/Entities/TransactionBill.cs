using ArquitecturePattern.Domain.Entities.Abstractions;

namespace ArquitecturePattern.Domain.Entities
{
    // A classe TransactionBill esta herdando da classe Transaction, que é abstrata 
    // Como se ela pertencesse a classe Transaction
    public class TransactionBill : Transaction
    {
        public string Barcode { get; set; } = string.Empty;

        // Gerando a descrição da transação de pagamento de conta
        public override string Description()
        {
            return $"Payment of Bill: {Barcode}, Value: {Value:C}";
        }
    }
}