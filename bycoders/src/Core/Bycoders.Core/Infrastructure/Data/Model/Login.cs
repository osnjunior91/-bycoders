using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bycoders.Domain.Infrastructure.Data.Model
{
    public class Login
    {
        public Login(string email, string password)
        {
            if (email.Length == 0)
                throw new ArgumentNullException(nameof(email));
            Email = email;
            if (password.Length == 0)
                throw new ArgumentNullException(nameof(password));
            Password = password;
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
