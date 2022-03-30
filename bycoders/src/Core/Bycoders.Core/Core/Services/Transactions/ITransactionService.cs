using Bycoders.Domain.Infrastructure.Data.Model;
using Bycoders.Lib.Bycoders.Lib.Domain.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bycoders.Domain.Core.Services
{
    public interface ITransactionService: IService<Transaction>
    {
        Task InsertListAsync(List<Transaction> items);

        Task<List<Transaction>> GetAllByNameAsync(string storeName);
    }
}
