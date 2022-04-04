using Bycoders.Domain.Infrastructure.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bycoders.Api.Model.Transactions
{
    public class TransactionListResponse
    {
        public List<TransactionListResponseItem> Items { get; private set; }

        public TransactionListResponse(List<Transaction> transactions)
        {
            if (transactions?.Count > 0)
            {
                Items = new List<TransactionListResponseItem>();
                foreach (var item in transactions)
                {
                    if (Items.Where(x => x.StoreName.Equals(item.StoreName)).Count() == 0)
                    {
                        Items.Add(new TransactionListResponseItem(item.StoreName,
                            transactions.Where(x => x.StoreName.Equals(item.StoreName)).ToList(),
                            transactions.Where(x => x.StoreName.Equals(item.StoreName)).ToList().Sum(s => s.Value)));
                    }
                }
            }
        }
    }
    public class TransactionListResponseItem
    {
        public TransactionListResponseItem(string storeName, List<Transaction> transactions, float sum)
        {
            StoreName = storeName;
            Transactions = new List<Transaction>(transactions);
            Sum = sum;
        }
        public string StoreName { get; private set; }
        public List<Transaction> Transactions { get; private set; }
        public float Sum { get; private set; }

    }
}
