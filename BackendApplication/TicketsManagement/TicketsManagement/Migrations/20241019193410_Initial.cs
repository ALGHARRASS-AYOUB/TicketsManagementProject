using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketsManagement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 14, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 16, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 17, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 10, 18, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 10, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 10, 16, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 10, 17, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 10, 18, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 10, 14, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 10, 16, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 10, 17, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 10, 18, 19, 34, 10, 144, DateTimeKind.Utc).AddTicks(1793));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 12, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 10, 14, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 15, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 10, 16, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 10, 8, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 10, 14, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 10, 15, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 10, 16, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 10, 12, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 10, 14, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 10, 15, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 10, 16, 18, 48, 26, 979, DateTimeKind.Utc).AddTicks(6068));
        }
    }
}
