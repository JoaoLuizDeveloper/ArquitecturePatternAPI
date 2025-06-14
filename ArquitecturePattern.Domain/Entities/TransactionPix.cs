using FinancialProject.Domain.Entities.Abstractions;

namespace FinancialProject.Domain.Entities
{
    // A classe TransactionPIX esta herdando da classe Transaction, que é abstrata 
    // Como se ela pertencesse a classe Transaction
    public class TransactionPix : Transaction
    {
        public string Key { get; set; } = string.Empty;

        public string? DescriptionPix { get; set; }

        //Gerando a descrição da transação via PIX
        public override string Description()
        {
            return $"PIX Sended to key: {Key}, Value: {Value:C}";
        }
    }
}