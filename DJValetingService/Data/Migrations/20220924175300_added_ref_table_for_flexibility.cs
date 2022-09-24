using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJValetingService.Data.Migrations
{
    public partial class added_ref_table_for_flexibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ref_Flexibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flexibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Flexibilities", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1f1931-99b6-4efd-9127-fd6fc1274968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e40b8891-ea17-4a1f-bbf2-86694e3aadca", "AQAAAAEAACcQAAAAEJgd909A8W8tw9RYQdaN8XvmRl4VYE7IU64n4U2HjvqvQyUShePpmB20ljRMAe753w==", "96adc50a-ddf5-435a-abc0-e80ff17d9544" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ref_Flexibilities");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1f1931-99b6-4efd-9127-fd6fc1274968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b1ebfe1-15ca-4b86-b1af-b8709241d7cb", "AQAAAAEAACcQAAAAEGuPgcQAgn4yPWtCk0iaeq5hlcG+iRyKH9A7ZANBl/QVK32k+z9VTxz3zd8OLelvtw==", "57ff1a07-dc8d-4ea2-9d07-e572f9b98b78" });
        }
    }
}
