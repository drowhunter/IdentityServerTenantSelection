using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 537, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 541, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 544, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 544, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 540, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 540, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 540, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 540, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 539, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 12, 12, 539, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.InsertData(
                table: "IdentityResources",
                columns: new[] { "Id", "Created", "Description", "DisplayName", "Emphasize", "Enabled", "Name", "NonEditable", "Required", "ShowInDiscoveryDocument", "Updated" },
                values: new object[] { 3, new DateTime(2020, 7, 15, 10, 12, 12, 539, DateTimeKind.Utc).AddTicks(9031), "Tenant Database Name", "Database Name", true, true, "database_name", false, false, true, null });

            migrationBuilder.InsertData(
                table: "IdentityClaims",
                columns: new[] { "Id", "IdentityResourceId", "Type" },
                values: new object[] { 7, 3, "database_name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 205, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 209, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 213, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 213, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 208, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 208, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 208, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 208, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 207, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 207, DateTimeKind.Utc).AddTicks(8234));
        }
    }
}
