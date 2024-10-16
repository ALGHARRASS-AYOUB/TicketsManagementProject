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
                    { 1, new DateTime(2024, 10, 10, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6288), "desc 1 ", 0 },
                    { 2, new DateTime(2024, 10, 12, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6297), "desc 2", 1 },
                    { 3, new DateTime(2024, 10, 13, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6300), "desc 3", 0 },
                    { 4, new DateTime(2024, 10, 14, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6302), "desc 4", 0 },
                    { 5, new DateTime(2024, 10, 6, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6303), "desc 5 ", 0 },
                    { 6, new DateTime(2024, 10, 12, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6305), "desc 6", 1 },
                    { 7, new DateTime(2024, 10, 13, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6307), "desc 7", 0 },
                    { 8, new DateTime(2024, 10, 14, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6309), "desc 8", 0 },
                    { 9, new DateTime(2024, 10, 10, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6311), "desc 9 ", 0 },
                    { 10, new DateTime(2024, 10, 12, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6312), "desc 10", 1 },
                    { 11, new DateTime(2024, 10, 13, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6314), "desc 11", 0 },
                    { 12, new DateTime(2024, 10, 14, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6316), "desc 12", 0 }
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
