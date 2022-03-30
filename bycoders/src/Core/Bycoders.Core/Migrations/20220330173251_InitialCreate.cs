using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bycoders.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeTransactions",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTransactions", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeTransactionCode = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    PersonDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_TypeTransactions_TypeTransactionCode",
                        column: x => x.TypeTransactionCode,
                        principalTable: "TypeTransactions",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TypeTransactions",
                columns: new[] { "Code", "Description", "Kind" },
                values: new object[,]
                {
                    { 1, "Débito", 0 },
                    { 2, "Boleto", 1 },
                    { 3, "Financiamento", 1 },
                    { 4, "Crédito", 0 },
                    { 5, "Recebimento Empréstimo", 0 },
                    { 6, "Vendas", 0 },
                    { 7, "Recebimento TED", 0 },
                    { 8, "Recebimento DOC", 0 },
                    { 9, "Aluguel", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TypeTransactionCode",
                table: "Transactions",
                column: "TypeTransactionCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "TypeTransactions");
        }
    }
}
