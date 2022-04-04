using Bycoders.Domain.Core.Services.Auth;
using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bycoders.Test.Domain.Core.Services
{
    [TestFixture]
    public class AuthServiceTest
    {
        private Mock<IConfiguration> _configuration;
        
        [SetUp]
        public void Setup()
        {
            _configuration = new Mock<IConfiguration>();
            _configuration.SetupGet(x => x[It.Is<string>(s => s == "SecretKey")]).Returns("DmSAzDlUXRak7hdXwY2em5sdKOmXz83F");
        }

        [TestCase("teste@teste.com", "123456")]
        public void When_Auth_Login_IsOk(string email, string password)
        {
            var loginService = new AuthService(_configuration.Object);
            Assert.IsInstanceOf<string>(loginService.Login(new Login(email, password))); 
        }
    }
}
