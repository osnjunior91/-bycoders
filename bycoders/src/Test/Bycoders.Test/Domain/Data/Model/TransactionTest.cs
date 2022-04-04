using Bycoders.Domain.Infrastructure.Data.Model;
using NUnit.Framework;
using System;

namespace Bycoders.Test.Domain.Data.Model
{
    [TestFixture]
    public class TransactionTest
    {
        [TestCase(1, "2012-1-20", 25, "12345678911", "8473****1231", "Dona da Loja", "Loja Teste", "2012-1-20")]
        public void When_Transaction_Create_IsOk(int typeTransactionCode, DateTime date, float value, string personDocument,
            string cardNumber, string storeManager, string storeName, DateTime createdAt)
        {
            var transaction = new Transaction(typeTransactionCode, date, value, personDocument,
            cardNumber, storeManager, storeName, createdAt);

            Assert.IsNotNull(transaction);
        }

        [TestCase(0, "2012-1-20", 25, "12345678911", "8473****1231", "Dona da Loja", "Loja Teste", "2012-1-20")]
        [TestCase(1, "1/1/0001 12:00:00 AM", 25, "12345678911", "8473****1231","Dona da Loja", "Loja Teste", "2012-1-20")]
        [TestCase(1, "2012-1-20", 0, "12345678911", "8473****1231", "Dona da Loja", "Loja Teste", "2012-1-20")]
        [TestCase(1, "2012-1-20", 10, "123456789", "8473****1231", "Dona da Loja", "Loja Teste", "2012-1-20")]
        [TestCase(1, "2012-1-20", 25, "12345678911", "8473****12", "Dona da Loja", "Loja Teste", "2012-1-20")]
        [TestCase(1, "2012-1-20", 25, "12345678911", "8473****1231", "", "Loja Teste", "2012-1-20")]
        [TestCase(1, "2012-1-20", 25, "12345678911", "8473****1231", "Dona da Loja", "", "2012-1-20")]
        public void When_Transaction_Create_IsNotOk(int typeTransactionCode, DateTime date, float value, string personDocument,
            string cardNumber, string storeManager, string storeName, DateTime createdAt)
        {
            Assert.Throws<ArgumentNullException>(() => new Transaction(typeTransactionCode, date, value, personDocument,
            cardNumber, storeManager, storeName, createdAt));
        }

        [TestCase("3201903010000014200096206760174753****3153153453JOÃO MACEDO   BAR DO JOÃO")]
        public void When_Transaction_ExplicitOperator_IsOk(string line)
        {
            var transaction = (Transaction)line;

            Assert.IsNotNull(transaction);
            Assert.IsTrue(transaction.CardNumber.Equals("4753****3153"));
            Assert.IsTrue(transaction.PersonDocument.Equals("09620676017"));
            Assert.IsTrue(transaction.StoreManager.Equals("JOÃO MACEDO"));
            Assert.IsTrue(transaction.StoreName.Equals("BAR DO JOÃO"));
            Assert.AreEqual(transaction.TypeTransactionCode, 3);
            Assert.AreEqual(transaction.Value, 142);
            Assert.AreEqual(transaction.Date, new DateTime(2019,3,1,15,34,53));

        }
    }
}
