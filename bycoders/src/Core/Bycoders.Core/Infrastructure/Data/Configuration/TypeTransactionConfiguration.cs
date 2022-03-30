using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bycoders.Domain.Infrastructure.Data.Configuration
{
    public class TypeTransactionConfiguration : IEntityTypeConfiguration<TypeTransaction>
    {
        public void Configure(EntityTypeBuilder<TypeTransaction> builder)
        {
            builder.ToTable("type-transaction").HasKey(x => x.Code);
        }
    }
}
