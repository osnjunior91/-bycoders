using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Bycoders.Domain.Core.Services.Upload
{
    public class UploadFile : IUploadFile
    {
        private readonly ITransactionService _transactionService;
        public UploadFile(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        public async Task UploadFileAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new Exception("File shouldn't be null or empty");
            }
            List<Transaction> transactions = new List<Transaction>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    transactions.Add((Transaction)await reader.ReadLineAsync());
                }
            }
            await _transactionService.InsertListAsync(transactions);
        }
    }
}
