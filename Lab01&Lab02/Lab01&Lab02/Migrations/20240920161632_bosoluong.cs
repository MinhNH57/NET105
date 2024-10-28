using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab01Lab02.Migrations
{
    /// <inheritdoc />
    public partial class bosoluong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "Id",
                keyValue: new Guid("c0e2476e-89b7-48b1-85de-6b4e3ee2887e"));

            migrationBuilder.DropColumn(
                name: "soLuong",
                table: "tickets");

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"),
                column: "Date",
                value: new DateTime(2024, 9, 20, 23, 16, 32, 84, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "Id", "IDEvent", "Price", "SeatNumber" },
                values: new object[] { new Guid("83b5da7f-684a-4b86-a2cf-a75b2ef7c07b"), new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"), 200000m, "S16" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "Id",
                keyValue: new Guid("83b5da7f-684a-4b86-a2cf-a75b2ef7c07b"));

            migrationBuilder.AddColumn<int>(
                name: "soLuong",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"),
                column: "Date",
                value: new DateTime(2024, 9, 20, 23, 0, 28, 28, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "Id", "IDEvent", "Price", "SeatNumber", "soLuong" },
                values: new object[] { new Guid("c0e2476e-89b7-48b1-85de-6b4e3ee2887e"), new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"), 200000m, "S16", 0 });
        }
    }
}
