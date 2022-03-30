using Bycoders.Domain.Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bycoders.Domain.Core.Services.Auth
{
    public interface IAuthService
    {
        string LoginAsync(Login login);
    }
}
