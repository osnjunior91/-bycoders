using Bycoders.Domain.Infrastructure.Data.Context;
using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bycoders.Domain.Infrastructure.Data.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DataContext _dataContext;
        private readonly DbSet<Transaction> _dataset;
        public TransactionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dataset = dataContext.Set<Transaction>();
        }

        public async Task<List<Transaction>> GetAllByNameAsync(string storeName)
        {
            return await _dataset.AsQueryable().Where(x => x.StoreName.Contains(storeName))
                .Include(fk => fk.Type).ToListAsync();
        }

        public async Task InsertListAsync(List<Transaction> items)
        {
            await _dataset.AddRangeAsync(items);
            await _dataContext.SaveChangesAsync();
        }
    }
}
