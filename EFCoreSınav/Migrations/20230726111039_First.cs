using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSınav.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminBilgileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminBilgileri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlbumunSanatcisi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AlbumCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlbumFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IndirimOrani = table.Column<double>(type: "float", maxLength: 3, nullable: true),
                    SatisaDevamEdiyorMu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminBilgileri_KullaniciAdi",
                table: "AdminBilgileri",
                column: "KullaniciAdi",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminBilgileri");

            migrationBuilder.DropTable(
                name: "Albumler");
        }
    }
}
