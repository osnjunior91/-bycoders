using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Bycoders.Domain.Core.Services.Upload
{
    public interface IUploadFileService
    {
        Task UploadFileAsync(IFormFile file);
    }
}
