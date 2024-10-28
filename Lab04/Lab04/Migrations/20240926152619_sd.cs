using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab04.Migrations
{
    /// <inheritdoc />
    public partial class sd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "Id",
                keyValue: new Guid("56419b6c-de1e-4b45-a63e-28016894e7b3"));

            migrationBuilder.InsertData(
                table: "SinhVien",
                columns: new[] { "Id", "Age", "ClassId", "Major", "Name" },
                values: new object[] { new Guid("1d7ad6cd-2e1d-4ec8-9b31-8e6c8a88c635"), 20, new Guid("3e581809-e2a0-4848-a30a-a9d9d7f2f72a"), "CNTT", "Nguyen Hong Minh" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "Id",
                keyValue: new Guid("1d7ad6cd-2e1d-4ec8-9b31-8e6c8a88c635"));

            migrationBuilder.InsertData(
                table: "SinhVien",
                columns: new[] { "Id", "Age", "ClassId", "Major", "Name" },
                values: new object[] { new Guid("56419b6c-de1e-4b45-a63e-28016894e7b3"), 20, new Guid("3e581809-e2a0-4848-a30a-a9d9d7f2f72a"), "CNTT", "Nguyen Hong Minh" });
        }
    }
}
