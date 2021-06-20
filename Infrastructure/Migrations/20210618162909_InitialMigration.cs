using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecreationObjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Stars = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecreationObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Patronymic = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    UserUid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    RecreationObjectId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_RecreationObjects_RecreationObjectId",
                        column: x => x.RecreationObjectId,
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    RecreationObjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.RecreationObjectId);
                    table.ForeignKey(
                        name: "FK_Contacts_RecreationObjects_RecreationObjectId",
                        column: x => x.RecreationObjectId,
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    RecreationObjectId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diseases_RecreationObjects_RecreationObjectId",
                        column: x => x.RecreationObjectId,
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HealingMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    RecreationObjectId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealingMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealingMethods_RecreationObjects_RecreationObjectId",
                        column: x => x.RecreationObjectId,
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecreationEmail = table.Column<string>(type: "text", nullable: true),
                    MessageText = table.Column<string>(type: "text", nullable: true),
                    RecreationObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMessages_RecreationObjects_RecreationObjectId",
                        column: x => x.RecreationObjectId,
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMessages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_RecreationObjectId",
                table: "AdditionalServices",
                column: "RecreationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_RecreationObjectId",
                table: "Diseases",
                column: "RecreationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_HealingMethods_RecreationObjectId",
                table: "HealingMethods",
                column: "RecreationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_RecreationObjectId",
                table: "UserMessages",
                column: "RecreationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_UserId",
                table: "UserMessages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalServices");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "HealingMethods");

            migrationBuilder.DropTable(
                name: "UserMessages");

            migrationBuilder.DropTable(
                name: "RecreationObjects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
