using Microsoft.AspNetCore.Mvc;
using ArquitecturePattern.Domain.Entities;
using ArquitecturePattern.Domain.Entities.Abstractions;

namespace ArquitecturePattern.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        #region Polimorfism example with transactions
        /// <summary>
        /// Shows a polimorfism with a list of transactions
        /// </summary>
        [HttpGet("ListTransactions")]
        public IActionResult ListTransactions()
        {
            // Usando a classe base Transaction como tipo de referência
            // Consigo trabalhar com as classes filhas TransactionPix e TransactionBill
            HashSet<Transaction> transactions = new()
            {
                new TransactionPix { Value = 150, Key = "joaoluizdeveloper@gmail.com", DescriptionPix= "Pix are a payment method exclusive from Brazil!" },
                new TransactionBill { Value = 250, Barcode = "237933812860008" }
            };

            var resultado = transactions.Select(t => new
            {
                type = t.GetType().Name,
                description = t.Description(),
                extraDescription = t is TransactionPix pix ? pix.DescriptionPix : "",
                resume = t.Resume()
            });

            return Ok(resultado);
        }
        #endregion
    }
}
