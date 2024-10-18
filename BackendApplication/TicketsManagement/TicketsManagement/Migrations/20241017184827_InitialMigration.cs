using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketsManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "Date", "Description", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6044), "desc 1 ", 0 },
                    { 2, new DateTime(2024, 10, 14, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6052), "desc 2", 1 },
                    { 3, new DateTime(2024, 10, 15, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6054), "desc 3", 0 },
                    { 4, new DateTime(2024, 10, 16, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6055), "desc 4", 0 },
                    { 5, new DateTime(2024, 10, 8, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6057), "desc 5 ", 0 },
                    { 6, new DateTime(2024, 10, 14, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6059), "desc 6", 1 },
                    { 7, new DateTime(2024, 10, 15, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6060), "desc 7", 0 },
                    { 8, new DateTime(2024, 10, 16, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6062), "desc 8", 0 },
                    { 9, new DateTime(2024, 10, 12, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6063), "desc 9 ", 0 },
                    { 10, new DateTime(2024, 10, 14, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6065), "desc 10", 1 },
                    { 11, new DateTime(2024, 10, 15, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6066), "desc 11", 0 },
                    { 12, new DateTime(2024, 10, 16, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6068), "desc 12", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
