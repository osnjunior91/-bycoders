using Bycoders.Domain.Infrastructure.Data.Model;
using Bycoders.Lib.Bycoders.Lib.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bycoders.Domain.Infrastructure.Data.Repository
{
    public interface ITransactionRepository: IRepository<Transaction>
    {
        Task InsertListAsync(List<Transaction> items);
    }
}
