using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJValetingService.Data.Migrations
{
    public partial class added_seed_data_for_ref_flexibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1f1931-99b6-4efd-9127-fd6fc1274968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d11d9a2-0762-49da-af7c-4b3fb158a3cc", "AQAAAAEAACcQAAAAEKj96OkOlVJ1zJjfWwFu1bUj4SIznQrVpITJCFlIzFgpd2eAW6o6MMfZImfbIp4cvA==", "110d84b4-bfaa-42d7-9448-a7fa99f8b667" });

            migrationBuilder.InsertData(
                table: "Ref_Flexibilities",
                columns: new[] { "Id", "Flexibility", "Removed" },
                values: new object[,]
                {
                    { 1, "+/- 1 Day", false },
                    { 2, "+/- 2 Day", false },
                    { 3, "+/- 3 Day", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ref_Flexibilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ref_Flexibilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ref_Flexibilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1f1931-99b6-4efd-9127-fd6fc1274968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e40b8891-ea17-4a1f-bbf2-86694e3aadca", "AQAAAAEAACcQAAAAEJgd909A8W8tw9RYQdaN8XvmRl4VYE7IU64n4U2HjvqvQyUShePpmB20ljRMAe753w==", "96adc50a-ddf5-435a-abc0-e80ff17d9544" });
        }
    }
}
