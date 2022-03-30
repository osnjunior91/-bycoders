using Bycoders.Domain.Core.Services;
using Bycoders.Domain.Core.Services.Upload;
using Bycoders.Domain.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Bycoders.Domain.InversionOfControl
{
    public static class InversionOfControl
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IUploadFile, UploadFile>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ITransactionService, TransactionService>();
        }
    }
}
