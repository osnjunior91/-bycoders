using Bycoders.Domain.Infrastructure.Data.Model;

namespace Bycoders.Domain.Core.Services.Auth
{
    public interface IAuthService
    {
        string Login(Login login);
    }
}
