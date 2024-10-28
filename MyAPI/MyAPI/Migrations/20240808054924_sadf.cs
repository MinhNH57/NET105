using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPI.Migrations
{
    public partial class sadf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "chatLieus",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatLieus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DayDeos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenClDay = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayDeos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiMays",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiMay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenMay = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMays", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MatKinhs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenCl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatKinhs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MauSacs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSacs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamThanhLap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DongHos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamRaDoi = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiMayID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MatKinhID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    thuonghieuID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongHos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DongHos_LoaiMays_LoaiMayID",
                        column: x => x.LoaiMayID,
                        principalTable: "LoaiMays",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DongHos_MatKinhs_MatKinhID",
                        column: x => x.MatKinhID,
                        principalTable: "MatKinhs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DongHos_ThuongHieus_thuonghieuID",
                        column: x => x.thuonghieuID,
                        principalTable: "ThuongHieus",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DongHoCTs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamSX = table.Column<int>(type: "int", nullable: false),
                    TienIch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayDeoID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DongHoID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongHoCTs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DongHoCTs_DayDeos_DayDeoID",
                        column: x => x.DayDeoID,
                        principalTable: "DayDeos",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DongHoCTs_DongHos_DongHoID",
                        column: x => x.DongHoID,
                        principalTable: "DongHos",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DongHoCTs_Size_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Size",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DongHoCT_ChatLieu",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    donghoctID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    chatlieuID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongHoCT_ChatLieu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DongHoCT_ChatLieu_chatLieus_chatlieuID",
                        column: x => x.chatlieuID,
                        principalTable: "chatLieus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DongHoCT_ChatLieu_DongHoCTs_donghoctID",
                        column: x => x.donghoctID,
                        principalTable: "DongHoCTs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DongHoCT_MauSac",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    donghoctID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    mausacID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongHoCT_MauSac", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DongHoCT_MauSac_DongHoCTs_donghoctID",
                        column: x => x.donghoctID,
                        principalTable: "DongHoCTs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DongHoCT_MauSac_MauSacs_mausacID",
                        column: x => x.mausacID,
                        principalTable: "MauSacs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DongHoCT_ChatLieu_chatlieuID",
                table: "DongHoCT_ChatLieu",
                column: "chatlieuID");

            migrationBuilder.CreateIndex(
                name: "IX_DongHoCT_ChatLieu_donghoctID",
                table: "DongHoCT_ChatLieu",
                column: "donghoctID");

            migrationBuilder.CreateIndex(
                name: "IX_DongHoCT_MauSac_donghoctID",
                table: "DongHoCT_MauSac",
                column: "donghoctID");

            migrationBuilder.CreateIndex(
                name: "IX_DongHoCT_MauSac_mausacID",
                table: "DongHoCT_MauSac",
                column: "mausacID");

            migrationBuilder.CreateIndex(
                name: "IX_DongHoCTs_DayDeoID",
                table: "DongHoCTs",
                column: "DayDeoID",
                unique: true,
                filter: "[DayDeoID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DongHoCTs_DongHoID",
                table: "DongHoCTs",
                column: "DongHoID");

            migrationBuilder.CreateIndex(
                name: "IX_DongHoCTs_SizeID",
                table: "DongHoCTs",
                column: "SizeID",
                unique: true,
                filter: "[SizeID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DongHos_LoaiMayID",
                table: "DongHos",
                column: "LoaiMayID",
                unique: true,
                filter: "[LoaiMayID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DongHos_MatKinhID",
                table: "DongHos",
                column: "MatKinhID",
                unique: true,
                filter: "[MatKinhID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DongHos_thuonghieuID",
                table: "DongHos",
                column: "thuonghieuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DongHoCT_ChatLieu");

            migrationBuilder.DropTable(
                name: "DongHoCT_MauSac");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "chatLieus");

            migrationBuilder.DropTable(
                name: "DongHoCTs");

            migrationBuilder.DropTable(
                name: "MauSacs");

            migrationBuilder.DropTable(
                name: "DayDeos");

            migrationBuilder.DropTable(
                name: "DongHos");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "LoaiMays");

            migrationBuilder.DropTable(
                name: "MatKinhs");

            migrationBuilder.DropTable(
                name: "ThuongHieus");
        }
    }
}
