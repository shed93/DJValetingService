using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJValetingService.Data.Migrations
{
    public partial class added_seed_admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8b1f1931-99b6-4efd-9127-fd6fc1274968", 0, "0b1ebfe1-15ca-4b86-b1af-b8709241d7cb", "admin@test.com", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEGuPgcQAgn4yPWtCk0iaeq5hlcG+iRyKH9A7ZANBl/QVK32k+z9VTxz3zd8OLelvtw==", null, false, "57ff1a07-dc8d-4ea2-9d07-e572f9b98b78", false, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1f1931-99b6-4efd-9127-fd6fc1274968");
        }
    }
}
