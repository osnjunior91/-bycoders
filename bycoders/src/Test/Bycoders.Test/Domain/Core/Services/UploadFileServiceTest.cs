using Bycoders.Domain.Core.Services;
using Bycoders.Domain.Core.Services.Upload;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace Bycoders.Test.Domain.Core.Services
{
    [TestFixture]
    public class UploadFileServiceTest
    {
        private Mock<ITransactionService> _transactionService;
        private UploadFileService _uploadFileService;

        [SetUp]
        public void Setup()
        {
            _transactionService = new Mock<ITransactionService>();
            _transactionService.Setup(x => x.GetAllByNameAsync(It.IsAny<string>())).Verifiable();
            _uploadFileService = new UploadFileService(_transactionService.Object);
        }
        [Test]
        public void When_UploadFile_IsNotOk()
        {
            Assert.ThrowsAsync<Exception>(() => _uploadFileService.UploadFileAsync(null));
        }

        [Test]
        public void When_UploadFile_IsOk()
        {
            var content = new StringBuilder();
            content.AppendLine("3201903010000014200096206760174753****3153153453JOÃO MACEDO   BAR DO JOÃO");
            content.AppendLine("5201903010000013200556418150633123****7687145607MARIA JOSEFINALOJA DO Ó - MATRIZ");
            content.AppendLine("3201903010000012200845152540736777****1313172712MARCOS PEREIRAMERCADO DA AVENIDA");
            content.AppendLine("1201903010000015200096206760171234****7890233000JOÃO MACEDO   BAR DO JOÃO");
            
            Assert.DoesNotThrowAsync(() => _uploadFileService.UploadFileAsync(CreateTestFormFile(content)));
        }

        private IFormFile CreateTestFormFile(StringBuilder content)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(content.ToString());

            return new FormFile(
                baseStream: new MemoryStream(bytes),
                baseStreamOffset: 0,
                length: bytes.Length,
                name: "Data",
                fileName: "TestFile.txt"
            );
        }
    }
}
