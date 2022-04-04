using Bycoders.Domain.Core.Services;
using Bycoders.Domain.Infrastructure.Data.Model;
using Bycoders.Domain.Infrastructure.Data.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bycoders.Test.Domain.Core.Services
{
    [TestFixture]
    public class TransactionServiceTest
    {
        private Mock<ITransactionRepository> _transactionRepository;
        private TransactionService _transactionService;
        private List<Transaction> withFilter = new List<Transaction>();
        private List<Transaction> withOutFilter = new List<Transaction>();

        public TransactionServiceTest()
        {
            withFilter.Add(new Transaction(1, DateTime.Now, 25, "12345678911", "8473****1231", "Dona da Loja", "Loja Teste", DateTime.Now));
            withOutFilter.Add(new Transaction(1, DateTime.Now, 25, "12345678911", "8473****1231", "Dona da Loja", "Loja Teste", DateTime.Now));
            withOutFilter.Add(new Transaction(2, DateTime.Now, 30, "12345678911", "8473****1231", "Dona da Loja", "Loja Teste", DateTime.Now));
        }

        [SetUp]
        public void Setup()
        {
            _transactionRepository = new Mock<ITransactionRepository>();
            _transactionRepository.Setup(m => m.GetAllByNameAsync(It.IsAny<string>())).ReturnsAsync(withFilter);
            _transactionRepository.Setup(m => m.GetAllAsync()).ReturnsAsync(withOutFilter);
            _transactionService = new TransactionService(_transactionRepository.Object);

        }
        [Test]
        public async Task When_Find_Transaction_Without_Filter_IsOkAsync()
        {
            var retorno = await _transactionService.GetAllByNameAsync(string.Empty);
            Assert.IsTrue(retorno.Count == 2);
        }

        [Test]
        public void When_Find_Transaction_With_Filter_IsOk()
        {
            var retorno = _transactionService.GetAllByNameAsync("filter").Result;
            Assert.IsTrue(retorno.Count == 1);
        }
    }
}
