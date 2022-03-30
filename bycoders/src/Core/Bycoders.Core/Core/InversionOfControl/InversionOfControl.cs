using Bycoders.Domain.Core.Services.Upload;
using Microsoft.Extensions.DependencyInjection;

namespace Bycoders.Domain.InversionOfControl
{
    public static class InversionOfControl
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IUploadFile, UploadFile>();
        }
    }
}
