﻿// <auto-generated />
using System;
using Bycoders.Domain.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bycoders.Domain.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Bycoders.Domain.Infrastructure.Data.Model.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeTransactionCode")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("TypeTransactionCode");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Bycoders.Domain.Infrastructure.Data.Model.TypeTransaction", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kind")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("TypeTransactions");

                    b.HasData(
                        new
                        {
                            Code = 1,
                            Description = "Débito",
                            Kind = 0
                        },
                        new
                        {
                            Code = 2,
                            Description = "Boleto",
                            Kind = 1
                        },
                        new
                        {
                            Code = 3,
                            Description = "Financiamento",
                            Kind = 1
                        },
                        new
                        {
                            Code = 4,
                            Description = "Crédito",
                            Kind = 0
                        },
                        new
                        {
                            Code = 5,
                            Description = "Recebimento Empréstimo",
                            Kind = 0
                        },
                        new
                        {
                            Code = 6,
                            Description = "Vendas",
                            Kind = 0
                        },
                        new
                        {
                            Code = 7,
                            Description = "Recebimento TED",
                            Kind = 0
                        },
                        new
                        {
                            Code = 8,
                            Description = "Recebimento DOC",
                            Kind = 0
                        },
                        new
                        {
                            Code = 9,
                            Description = "Aluguel",
                            Kind = 1
                        });
                });

            modelBuilder.Entity("Bycoders.Domain.Infrastructure.Data.Model.Transaction", b =>
                {
                    b.HasOne("Bycoders.Domain.Infrastructure.Data.Model.TypeTransaction", "Type")
                        .WithMany()
                        .HasForeignKey("TypeTransactionCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}