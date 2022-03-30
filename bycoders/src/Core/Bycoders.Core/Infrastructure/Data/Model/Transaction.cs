using Bycoders.Lib.Bycoders.Lib.Domain.ExtensioMethods;
using Bycoders.Lib.Bycoders.Lib.Domain.Models;
using System;

namespace Bycoders.Domain.Infrastructure.Data.Model
{
    public class Transaction : Entity
    {
        public TypeTransaction Type { get; set; }
        public DateTime Date { get; set; }
        public float Value { get; set; }
        public string PersonDocument { get; set; }
        public string CardNumber { get; set; }
        public string StoreManager { get; set; }
        public string StoreName { get; set; }

        public static explicit operator Transaction(string line)
        {
            var retorno = new Transaction();
            retorno.Type = new TypeTransaction() { Code = int.Parse(line.Substring(0, 1)) };
            retorno.Date = line.Substring(1, 8).CNABDate();
            retorno.Value = float.Parse(line.Substring(9, 10)) / 100;
            retorno.PersonDocument = line.Substring(19, 11).Trim();
            retorno.CardNumber = line.Substring(30, 12).Trim();
            retorno.StoreManager = line.Substring(48, 14).Trim();
            retorno.StoreName = line.Substring(62).Trim();
            return retorno;
        }
    }
}
