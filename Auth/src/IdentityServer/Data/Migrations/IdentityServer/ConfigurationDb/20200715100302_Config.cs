using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class Config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 7, 15, 10, 3, 2, 205, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://localhost:4200");

            migrationBuilder.InsertData(
                table: "ClientCorsOrigins",
                columns: new[] { "Id", "ClientId", "Origin" },
                values: new object[] { 2, 4, "https://localhost:4200" });

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:4200/signout-callback-oidc");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:4200");

            migrationBuilder.InsertData(
                table: "ClientPostLogoutRedirectUris",
                columns: new[] { "Id", "ClientId", "PostLogoutRedirectUri" },
                values: new object[] { 3, 4, "https://localhost:4200" });

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "RedirectUri",
                value: "http://localhost:4200/signin-oidc");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "RedirectUri",
                value: "https://localhost:4200/callback.html");

            migrationBuilder.InsertData(
                table: "ClientRedirectUris",
                columns: new[] { "Id", "ClientId", "RedirectUri" },
                values: new object[,]
                {
                    { 4, 4, "http://localhost:4200" },
                    { 5, 4, "https://localhost:4200" },
                    { 6, 4, "http://localhost:4200/silent-renew.html" },
                    { 7, 4, "https://localhost:4200/silent-renew.html" },
                    { 3, 4, "https://localhost:4200/callback.html" }
                });

            migrationBuilder.InsertData(
                table: "ClientScopes",
                columns: new[] { "Id", "ClientId", "Scope" },
                values: new object[] { 9, 4, "database_name" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 590, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://localhost:5003");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:5002/signout-callback-oidc");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:5003/index.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "RedirectUri",
                value: "http://localhost:5002/signin-oidc");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "RedirectUri",
                value: "http://localhost:5003/callback.html");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 594, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 594, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 591, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 591, DateTimeKind.Utc).AddTicks(8400));
        }
    }
}
