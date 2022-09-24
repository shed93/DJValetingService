using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJValetingService.Data.Migrations
{
    public partial class added_valeting_request_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValetingRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlexibilityId = table.Column<int>(type: "int", nullable: false),
                    VehicleSizeId = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<bool>(type: "bit", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValetingRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValetingRequests_Ref_Flexibilities_FlexibilityId",
                        column: x => x.FlexibilityId,
                        principalTable: "Ref_Flexibilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ValetingRequests_Ref_VehicleSizes_VehicleSizeId",
                        column: x => x.VehicleSizeId,
                        principalTable: "Ref_VehicleSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ValetingRequests_FlexibilityId",
                table: "ValetingRequests",
                column: "FlexibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ValetingRequests_VehicleSizeId",
                table: "ValetingRequests",
                column: "VehicleSizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValetingRequests");
        }
    }
}
