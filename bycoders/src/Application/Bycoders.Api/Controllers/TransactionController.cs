using Bycoders.Api.Model.Transactions;
using Bycoders.Domain.Core.Services;
using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bycoders.Api.Controllers
{
    /// <summary>
    /// Controller transactions
    /// </summary>
    [Route("api/v1/transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        /// <summary>
        /// Find all query or find by name
        /// </summary>
        /// <param name="filter">Name of store(optional)</param>
        /// <returns>List of transactions</returns>
        [Route("store/all")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Transaction>), 200)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> GetAllByNameAsync([FromQuery] string filter)
        {
            try
            {
                return Ok(new TransactionListResponse(await _transactionService.GetAllByNameAsync(filter)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
