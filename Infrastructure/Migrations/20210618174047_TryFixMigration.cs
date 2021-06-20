using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class TryFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "recreation_service");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Users",
                newSchema: "recreation_service");

            migrationBuilder.RenameTable(
                name: "UserMessages",
                newName: "UserMessages",
                newSchema: "recreation_service");

            migrationBuilder.RenameTable(
                name: "RecreationObjects",
                newName: "RecreationObjects",
                newSchema: "recreation_service");

            migrationBuilder.RenameTable(
                name: "HealingMethods",
                newName: "HealingMethods",
                newSchema: "recreation_service");

            migrationBuilder.RenameTable(
                name: "Diseases",
                newName: "Diseases",
                newSchema: "recreation_service");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contacts",
                newSchema: "recreation_service");

            migrationBuilder.RenameTable(
                name: "AdditionalServices",
                newName: "AdditionalServices",
                newSchema: "recreation_service");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Users",
                schema: "recreation_service",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "UserMessages",
                schema: "recreation_service",
                newName: "UserMessages");

            migrationBuilder.RenameTable(
                name: "RecreationObjects",
                schema: "recreation_service",
                newName: "RecreationObjects");

            migrationBuilder.RenameTable(
                name: "HealingMethods",
                schema: "recreation_service",
                newName: "HealingMethods");

            migrationBuilder.RenameTable(
                name: "Diseases",
                schema: "recreation_service",
                newName: "Diseases");

            migrationBuilder.RenameTable(
                name: "Contacts",
                schema: "recreation_service",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "AdditionalServices",
                schema: "recreation_service",
                newName: "AdditionalServices");
        }
    }
}
