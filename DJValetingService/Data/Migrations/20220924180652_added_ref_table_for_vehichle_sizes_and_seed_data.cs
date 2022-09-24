using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJValetingService.Data.Migrations
{
    public partial class added_ref_table_for_vehichle_sizes_and_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ref_VehicleSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_VehicleSizes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ref_VehicleSizes",
                columns: new[] { "Id", "Removed", "Size" },
                values: new object[,]
                {
                    { 1, false, "Small" },
                    { 2, false, "Medium" },
                    { 3, false, "Large" },
                    { 4, false, "Van" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ref_VehicleSizes");
        }
    }
}
