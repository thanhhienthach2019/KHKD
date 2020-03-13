using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KHKDSolution.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DpLSXHs",
                columns: table => new
                {
                    SoLSX = table.Column<string>(maxLength: 15, nullable: false),
                    SoSOA = table.Column<string>(nullable: true),
                    MaKH = table.Column<string>(maxLength: 10, nullable: false),
                    SoTN = table.Column<string>(maxLength: 10, nullable: true),
                    SoDDH = table.Column<string>(maxLength: 15, nullable: true),
                    UserCreate = table.Column<Guid>(nullable: false),
                    NgayGH = table.Column<DateTime>(nullable: false),
                    NgayTN = table.Column<DateTime>(nullable: false),
                    NgayDP = table.Column<DateTime>(nullable: false),
                    NgayPH = table.Column<DateTime>(nullable: false),
                    NgayVTDU = table.Column<DateTime>(nullable: false),
                    NgayLap = table.Column<DateTime>(nullable: false),
                    NgayBBTN = table.Column<DateTime>(nullable: false),
                    NgayKiem = table.Column<DateTime>(nullable: false),
                    NgayNCVT = table.Column<DateTime>(nullable: false),
                    NgayDuPhong = table.Column<DateTime>(nullable: false),
                    GhiChu = table.Column<string>(maxLength: 400, nullable: true),
                    PhanBo = table.Column<int>(nullable: false),
                    BTP = table.Column<int>(nullable: false),
                    NgayGHM = table.Column<DateTime>(nullable: false),
                    SoPO = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DpLSXHs", x => x.SoLSX);
                    table.ForeignKey(
                        name: "FK_DpLSXHs_AppUsers_UserCreate",
                        column: x => x.UserCreate,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    MaSP = table.Column<string>(maxLength: 20, nullable: false),
                    MSSP = table.Column<string>(maxLength: 10, nullable: true),
                    MaCLSpPhu = table.Column<string>(maxLength: 10, nullable: true),
                    MaCLSP = table.Column<string>(maxLength: 10, nullable: true),
                    GhiChu = table.Column<string>(maxLength: 400, nullable: true),
                    UserCreate = table.Column<Guid>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    BTP = table.Column<int>(nullable: false),
                    TenBTP = table.Column<string>(maxLength: 20, nullable: true),
                    MaSAP = table.Column<string>(maxLength: 20, nullable: true),
                    MaKhuon = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_SanPhams_AppUsers_UserCreate",
                        column: x => x.UserCreate,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DpLSXLs",
                columns: table => new
                {
                    SoLSXID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLSX = table.Column<string>(maxLength: 15, nullable: false),
                    ChiNhanh = table.Column<string>(maxLength: 20, nullable: true),
                    MaSP = table.Column<string>(maxLength: 20, nullable: true),
                    MaMau = table.Column<string>(maxLength: 15, nullable: true),
                    MSM = table.Column<string>(maxLength: 10, nullable: true),
                    LoaiBTP = table.Column<string>(maxLength: 10, nullable: true),
                    MauBTP = table.Column<string>(maxLength: 5, nullable: true),
                    QuiCachBTL = table.Column<string>(maxLength: 20, nullable: true),
                    CoSoID = table.Column<int>(nullable: false),
                    SoLuong = table.Column<long>(nullable: false),
                    SoSOA = table.Column<string>(maxLength: 15, nullable: true),
                    SoDH = table.Column<string>(maxLength: 15, nullable: true),
                    SoDHK = table.Column<string>(maxLength: 15, nullable: true),
                    MauKhach = table.Column<string>(maxLength: 10, nullable: true),
                    CSDanTem = table.Column<string>(maxLength: 10, nullable: true),
                    MaSPK = table.Column<string>(nullable: true),
                    NgayPhatSinh = table.Column<DateTime>(nullable: false),
                    DVT = table.Column<string>(maxLength: 5, nullable: true),
                    DienGiaiCT = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DpLSXLs", x => x.SoLSXID);
                    table.ForeignKey(
                        name: "FK_DpLSXLs_SanPhams_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DpLSXLs_DpLSXHs_SoLSX",
                        column: x => x.SoLSX,
                        principalTable: "DpLSXHs",
                        principalColumn: "SoLSX",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DpLSXHs_UserCreate",
                table: "DpLSXHs",
                column: "UserCreate");

            migrationBuilder.CreateIndex(
                name: "IX_DpLSXLs_MaSP",
                table: "DpLSXLs",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_DpLSXLs_SoLSX",
                table: "DpLSXLs",
                column: "SoLSX");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_UserCreate",
                table: "SanPhams",
                column: "UserCreate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "DpLSXLs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "DpLSXHs");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
