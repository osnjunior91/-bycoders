using Bycoders.Domain.Infrastructure.Data.Model;
using NUnit.Framework;
using System;

namespace Bycoders.Test.Domain.Data.Model
{
    [TestFixture]
    public class LoginTest
    {
        [TestCase("teste@teste.com", "123456")]
        public void When_Login_Create_IsOk(string email, string password)
        {
            var login = new Login(email, password);
            Assert.IsNotNull(login);
        }

        [TestCase("", "123456")]
        [TestCase("teste@teste.com", "")]
        public void When_Login_Create_IsNotOk(string email, string password)
        {
            Assert.Throws<ArgumentNullException>(() => new Login(email, password));
        }
    }
}
