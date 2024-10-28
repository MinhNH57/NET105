using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeCRUD.Migrations
{
    /// <inheritdoc />
    public partial class dsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LopHocs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameClass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDLopHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SinhViens_LopHocs_IDLopHoc",
                        column: x => x.IDLopHoc,
                        principalTable: "LopHocs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LopHocs",
                columns: new[] { "ID", "NameClass" },
                values: new object[] { new Guid("dc3a2078-02ae-4002-8116-bd168fa48cbf"), "SD18406" });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "ID", "Address", "IDLopHoc", "Name" },
                values: new object[] { new Guid("ea6a0dfc-ae8d-41cd-9f43-f04284e3188c"), "Phung Xa", new Guid("dc3a2078-02ae-4002-8116-bd168fa48cbf"), "Nguyen Hong Minh" });

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_IDLopHoc",
                table: "SinhViens",
                column: "IDLopHoc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "LopHocs");
        }
    }
}
