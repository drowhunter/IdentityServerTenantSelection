using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Migrations.MasterDb
{
    public partial class companies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    DatabaseName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName", "DatabaseName", "EndDate", "StartDate", "UserId" },
                values: new object[] { 1L, "lalita", "LalitaDatabase", new DateTime(2020, 7, 15, 16, 5, 59, 661, DateTimeKind.Local).AddTicks(8173), new DateTime(2020, 7, 15, 16, 5, 59, 660, DateTimeKind.Local).AddTicks(8169), "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
