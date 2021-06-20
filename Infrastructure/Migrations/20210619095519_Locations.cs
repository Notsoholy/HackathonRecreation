using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Locations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecreationObjects_Location_LocationId",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                schema: "recreation_service",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                schema: "recreation_service",
                newName: "Locations",
                newSchema: "recreation_service");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                schema: "recreation_service",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecreationObjects_Locations_LocationId",
                schema: "recreation_service",
                table: "RecreationObjects",
                column: "LocationId",
                principalSchema: "recreation_service",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecreationObjects_Locations_LocationId",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                schema: "recreation_service",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                schema: "recreation_service",
                newName: "Location",
                newSchema: "recreation_service");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                schema: "recreation_service",
                table: "Location",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecreationObjects_Location_LocationId",
                schema: "recreation_service",
                table: "RecreationObjects",
                column: "LocationId",
                principalSchema: "recreation_service",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
