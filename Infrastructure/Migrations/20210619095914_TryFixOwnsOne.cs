using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Infrastructure.Migrations
{
    public partial class TryFixOwnsOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts",
                schema: "recreation_service");

            migrationBuilder.AddColumn<string>(
                name: "Contacts_Address",
                schema: "recreation_service",
                table: "RecreationObjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contacts_Email",
                schema: "recreation_service",
                table: "RecreationObjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contacts_Phone",
                schema: "recreation_service",
                table: "RecreationObjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contacts_Website",
                schema: "recreation_service",
                table: "RecreationObjects",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contacts_Address",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.DropColumn(
                name: "Contacts_Email",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.DropColumn(
                name: "Contacts_Phone",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.DropColumn(
                name: "Contacts_Website",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.CreateTable(
                name: "Contacts",
                schema: "recreation_service",
                columns: table => new
                {
                    RecreationObjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.RecreationObjectId);
                    table.ForeignKey(
                        name: "FK_Contacts_RecreationObjects_RecreationObjectId",
                        column: x => x.RecreationObjectId,
                        principalSchema: "recreation_service",
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
