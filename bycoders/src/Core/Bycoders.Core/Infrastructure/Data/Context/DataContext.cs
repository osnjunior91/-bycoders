using Bycoders.Domain.Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bycoders.Domain.Infrastructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TypeTransaction> TypeTransactions { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeTransaction>()
                    .HasData(
                        new TypeTransaction()
                        {
                            Code = 1,
                            Description = "Débito",
                            Kind = KindTransaction.Input
                        },
                        new TypeTransaction()
                        {
                            Code = 2,
                            Description = "Boleto",
                            Kind = KindTransaction.Output
                        },
                        new TypeTransaction()
                        {
                            Code = 3,
                            Description = "Financiamento",
                            Kind = KindTransaction.Output
                        },
                        new TypeTransaction()
                        {
                            Code = 4,
                            Description = "Crédito",
                            Kind = KindTransaction.Input
                        }, new TypeTransaction()
                        {
                            Code = 5,
                            Description = "Recebimento Empréstimo",
                            Kind = KindTransaction.Input
                        },
                        new TypeTransaction()
                        {
                            Code = 6,
                            Description = "Vendas",
                            Kind = KindTransaction.Input
                        },
                        new TypeTransaction()
                        {
                            Code = 7,
                            Description = "Recebimento TED",
                            Kind = KindTransaction.Input
                        }, new TypeTransaction()
                        {
                            Code = 8,
                            Description = "Recebimento DOC",
                            Kind = KindTransaction.Input
                        },
                        new TypeTransaction()
                        {
                            Code = 9,
                            Description = "Aluguel",
                            Kind = KindTransaction.Output
                        }
                    );
            base.OnModelCreating(modelBuilder);
        }

    }
}
