using Bycoders.Lib.Bycoders.Lib.Domain.ExtensioMethods;
using Bycoders.Lib.Bycoders.Lib.Domain.Models;
using System;

namespace Bycoders.Domain.Infrastructure.Data.Model
{
    public class Transaction : Entity
    {
        public Transaction(int typeTransactionCode, DateTime date, float value, string personDocument, 
            string cardNumber, string storeManager, string storeName, DateTime createdAt)
        {
            if (typeTransactionCode == 0)
                throw new ArgumentNullException(nameof(typeTransactionCode));
            TypeTransactionCode = typeTransactionCode;
            if (date == DateTime.MinValue)
                throw new ArgumentNullException(nameof(date));
            Date = date;
            if (value == float.MinValue)
                throw new ArgumentNullException(nameof(value));
            Value = value;
            if (personDocument.Length < 11)
                throw new ArgumentNullException(nameof(personDocument));
            PersonDocument = personDocument;
            if (cardNumber.Length < 12)
                throw new ArgumentNullException(nameof(cardNumber));
            CardNumber = cardNumber;
            if (storeManager.Length < 1)
                throw new ArgumentNullException(nameof(storeManager));
            StoreManager = storeManager;
            if (storeName.Length < 1)
                throw new ArgumentNullException(nameof(storeName));
            StoreName = storeName;
            CreatedAt = createdAt;
        }

        public int TypeTransactionCode { get; set; }
        public TypeTransaction Type { get; set; }
        public DateTime Date { get; set; }
        public float Value { get; set; }
        public string PersonDocument { get; set; }
        public string CardNumber { get; set; }
        public string StoreManager { get; set; }
        public string StoreName { get; set; }

        public static explicit operator Transaction(string line)
        {
            return new Transaction(int.Parse(line.Substring(0, 1)), line.Substring(1, 8).CNABDate(line.Substring(42, 6)), 
                float.Parse(line.Substring(9, 10)) / 100, line.Substring(19, 11).Trim(), line.Substring(30, 12).Trim(),
                line.Substring(48, 14).Trim(), line.Substring(62).Trim(), DateTime.Now);
        }
    }
}
