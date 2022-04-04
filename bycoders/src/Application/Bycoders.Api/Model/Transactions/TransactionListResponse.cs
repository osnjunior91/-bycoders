using Bycoders.Domain.Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bycoders.Api.Model.Transactions
{
    public class TransactionListResponse
    {
        public List<TransactionListResponseItem> Items { get; set; }

        public TransactionListResponse(List<Transaction> transactions)
        {
            Items = new List<TransactionListResponseItem>();
            if(transactions?.Count > 0)
            {
                foreach (var item in transactions)
                {
                    if(Items.Where(x => x.StoreName.Equals(item.StoreName)).Count() == 0)
                    {
                        Items.Add(new TransactionListResponseItem()
                        {
                            StoreName = item.StoreName,
                            Transactions = transactions.Where(x => x.StoreName.Equals(item.StoreName)).ToList(),
                            Sum = transactions.Where(x => x.StoreName.Equals(item.StoreName)).ToList().Sum(s => s.Value)
                        });
                    }
                }
            }
        }
    }
    public class TransactionListResponseItem
    {
        public string StoreName { get; set; }
        public List<Transaction> Transactions { get; set; }
        public float Sum { get; set; }
    }
}
