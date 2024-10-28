using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KIemTra.Migrations
{
    /// <inheritdoc />
    public partial class addSL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "soLuong",
                table: "DonHang",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "soLuong",
                table: "DonHang");
        }
    }
}
