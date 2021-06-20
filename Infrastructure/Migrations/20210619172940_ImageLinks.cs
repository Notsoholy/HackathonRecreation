using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Infrastructure.Migrations
{
    public partial class ImageLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Users_UserId",
                schema: "recreation_service",
                table: "UserMessages");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "recreation_service",
                table: "UserMessages",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "ImageLinks",
                schema: "recreation_service",
                table: "RecreationObjects",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Users_UserId",
                schema: "recreation_service",
                table: "UserMessages",
                column: "UserId",
                principalSchema: "recreation_service",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Users_UserId",
                schema: "recreation_service",
                table: "UserMessages");

            migrationBuilder.DropColumn(
                name: "ImageLinks",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "recreation_service",
                table: "UserMessages",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Users_UserId",
                schema: "recreation_service",
                table: "UserMessages",
                column: "UserId",
                principalSchema: "recreation_service",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
