using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab01Lab02.Migrations
{
    /// <inheritdoc />
    public partial class themsoLuong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "Id",
                keyValue: new Guid("b9c076b0-6650-4a1e-8848-a1042f83be46"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 9, 20, 19, 32, 15, 708, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "Id", "IDEvent", "Price", "SeatNumber" },
                values: new object[] { new Guid("b9c076b0-6650-4a1e-8848-a1042f83be46"), new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"), 200000m, "S16" });
        }
    }
}
