using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJValetingService.Data.Migrations
{
    public partial class fixing_hash_been_updated_on_admin_seed_every_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1f1931-99b6-4efd-9127-fd6fc1274968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b1ebfe1-15ca-4b86-b1af-b8709241d7cb", "AQAAAAEAACcQAAAAEGuPgcQAgn4yPWtCk0iaeq5hlcG+iRyKH9A7ZANBl/QVK32k+z9VTxz3zd8OLelvtw==", "57ff1a07-dc8d-4ea2-9d07-e572f9b98b78" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1f1931-99b6-4efd-9127-fd6fc1274968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d11d9a2-0762-49da-af7c-4b3fb158a3cc", "AQAAAAEAACcQAAAAEKj96OkOlVJ1zJjfWwFu1bUj4SIznQrVpITJCFlIzFgpd2eAW6o6MMfZImfbIp4cvA==", "110d84b4-bfaa-42d7-9448-a7fa99f8b667" });
        }
    }
}
