using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bycoders.Domain.Infrastructure.Data.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("transaction").HasKey(x => x.Id);
            builder.HasOne(x => x.Type)
                .WithMany()
                .HasForeignKey(x => x.TypeTransactionCode);
        }
    }
}
