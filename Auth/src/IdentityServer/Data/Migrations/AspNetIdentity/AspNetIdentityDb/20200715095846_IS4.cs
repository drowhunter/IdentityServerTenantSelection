using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class IS4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "Lalita Lalita");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "Lalita");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "Lalita");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "lalita@lalita.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "http://lalitacode.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "ClaimValue",
                value: "Code Code");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "ClaimValue",
                value: "Code");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "ClaimValue",
                value: "Code");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "ClaimValue",
                value: "code@code.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "ClaimValue",
                value: "http://lalitacode.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "ClaimValue",
                value: "{ 'street_address': 'Kathmandu', 'locality': 'Kathmandu', 'postal_code': 00000, 'country': 'Nepal' }");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "ClaimValue",
                value: "{ 'street_address': 'Kathmandu', 'locality': 'Kathmandu', 'postal_code': 00000, 'country': 'Nepal' }");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "ClaimValue",
                value: "Nepal");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0ab03cf0-73b6-44e8-aad6-e8bc9451a15b", "lalita@lalita.com", "LALITA@LALITA.COM", "LALITA", "AQAAAAEAACcQAAAAED8H++cJMpeb9REMfv9/oqkND5gh0estD8xVkTkc+InWw+ctzgql0Tj4dZHQBc1/7Q==", "e92cc04c-789d-430f-8c7a-cf5665d59f92", "lalita" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a8cf8c4e-331c-40a3-a593-469b47875960", "code@code.com", "CODE@CODE.COM", "CODE", "AQAAAAEAACcQAAAAEL7qkA7uEpdOyN8GcvPsBAOkHbVCHjkLkRGBxfNHAVsKicqw8H+UJslvG5isYWHn9Q==", "114c3aa7-5a1b-4e2a-a780-b029dd1ead8e", "code" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "Alice Smith");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "Alice");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "Smith");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "AliceSmith@email.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "http://alice.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "ClaimValue",
                value: "Bob Smith");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "ClaimValue",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "ClaimValue",
                value: "Smith");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "ClaimValue",
                value: "BobSmith@email.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "ClaimValue",
                value: "http://bob.com");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "ClaimValue",
                value: "{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "ClaimValue",
                value: "{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "ClaimValue",
                value: "somewhere");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9bf51674-22d5-489c-8840-b6b7e5c168ea", "AliceSmith@email.com", "ALICESMITH@EMAIL.COM", "ALICE", "AQAAAAEAACcQAAAAEI2ng2eTwVWp1oUlhUFiQjxPxFUPS1tqDTn1P4lL/nA3mCXDzuXyu3XuAaNdfaaX5w==", "13e1a5ea-5e35-4145-8dd4-e090d75cf684", "alice" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "85d9f0e8-0ebf-4cb6-9591-0a590dc689fc", "BobSmith@email.com", "BOBSMITH@EMAIL.COM", "BOB", "AQAAAAEAACcQAAAAENKBEy8L1HDu5r71QgePuhB8aFz1wTZjw8ttPNS+3gpAM+fbBn2xyoCIDeWEUQER0g==", "ae733bfd-6269-45e0-a870-9b5e3c8d1702", "bob" });
        }
    }
}
