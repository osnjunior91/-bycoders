using Bycoders.Domain.Core.Services;
using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bycoders.Api.Controllers
{
    [Route("api/v1/transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [Route("store/all")]
        [HttpPost]
        [ProducesResponseType(typeof(List<Transaction>), 200)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> FileUpload([FromQuery] string filter)
        {
            try
            {
                return Ok(await _transactionService.GetAllByNameAsync(filter));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
