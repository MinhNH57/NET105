using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab01Lab02.Migrations
{
    /// <inheritdoc />
    public partial class dsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IDEvent = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tickets_events_IDEvent",
                        column: x => x.IDEvent,
                        principalTable: "events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "events",
                columns: new[] { "Id", "Date", "Location", "Name" },
                values: new object[] { new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"), new DateTime(2024, 9, 20, 19, 32, 15, 708, DateTimeKind.Local).AddTicks(1250), "Ha noi", "Nhung thanh pho mi mang" });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "Id", "IDEvent", "Price", "SeatNumber" },
                values: new object[] { new Guid("b9c076b0-6650-4a1e-8848-a1042f83be46"), new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"), 200000m, "S16" });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_IDEvent",
                table: "tickets",
                column: "IDEvent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "events");
        }
    }
}
