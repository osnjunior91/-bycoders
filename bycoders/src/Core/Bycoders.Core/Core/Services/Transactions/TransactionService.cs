using Bycoders.Domain.Infrastructure.Data.Model;
using Bycoders.Domain.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bycoders.Domain.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<List<Transaction>> GetAllByNameAsync(string storeName)
        {
            return (storeName?.Length > 0) 
                ? await _transactionRepository.GetAllByNameAsync(storeName)
                : await _transactionRepository.GetAllAsync();
        }

        public async Task InsertListAsync(List<Transaction> items)
        {
            await _transactionRepository.InsertListAsync(items);
        }
    }
}
