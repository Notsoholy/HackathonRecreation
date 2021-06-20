using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Infrastructure.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalServices_RecreationObjects_RecreationObjectId",
                schema: "recreation_service",
                table: "AdditionalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Diseases_RecreationObjects_RecreationObjectId",
                schema: "recreation_service",
                table: "Diseases");

            migrationBuilder.DropForeignKey(
                name: "FK_HealingMethods_RecreationObjects_RecreationObjectId",
                schema: "recreation_service",
                table: "HealingMethods");

            migrationBuilder.DropIndex(
                name: "IX_HealingMethods_RecreationObjectId",
                schema: "recreation_service",
                table: "HealingMethods");

            migrationBuilder.DropIndex(
                name: "IX_Diseases_RecreationObjectId",
                schema: "recreation_service",
                table: "Diseases");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalServices_RecreationObjectId",
                schema: "recreation_service",
                table: "AdditionalServices");

            migrationBuilder.DropColumn(
                name: "RecreationObjectId",
                schema: "recreation_service",
                table: "HealingMethods");

            migrationBuilder.DropColumn(
                name: "RecreationObjectId",
                schema: "recreation_service",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "RecreationObjectId",
                schema: "recreation_service",
                table: "AdditionalServices");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "recreation_service",
                table: "RecreationObjects",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdditionalServiceRecreationObject",
                schema: "recreation_service",
                columns: table => new
                {
                    AdditionalServicesId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecreationObjectsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServiceRecreationObject", x => new { x.AdditionalServicesId, x.RecreationObjectsId });
                    table.ForeignKey(
                        name: "FK_AdditionalServiceRecreationObject_AdditionalServices_Additi~",
                        column: x => x.AdditionalServicesId,
                        principalSchema: "recreation_service",
                        principalTable: "AdditionalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalServiceRecreationObject_RecreationObjects_Recreat~",
                        column: x => x.RecreationObjectsId,
                        principalSchema: "recreation_service",
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseRecreationObject",
                schema: "recreation_service",
                columns: table => new
                {
                    DiseasesId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecreationObjectsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseRecreationObject", x => new { x.DiseasesId, x.RecreationObjectsId });
                    table.ForeignKey(
                        name: "FK_DiseaseRecreationObject_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalSchema: "recreation_service",
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseRecreationObject_RecreationObjects_RecreationObjects~",
                        column: x => x.RecreationObjectsId,
                        principalSchema: "recreation_service",
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealingMethodRecreationObject",
                schema: "recreation_service",
                columns: table => new
                {
                    HealingMethodsId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecreationObjectsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealingMethodRecreationObject", x => new { x.HealingMethodsId, x.RecreationObjectsId });
                    table.ForeignKey(
                        name: "FK_HealingMethodRecreationObject_HealingMethods_HealingMethods~",
                        column: x => x.HealingMethodsId,
                        principalSchema: "recreation_service",
                        principalTable: "HealingMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealingMethodRecreationObject_RecreationObjects_RecreationO~",
                        column: x => x.RecreationObjectsId,
                        principalSchema: "recreation_service",
                        principalTable: "RecreationObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "recreation_service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecreationObjects_LocationId",
                schema: "recreation_service",
                table: "RecreationObjects",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServiceRecreationObject_RecreationObjectsId",
                schema: "recreation_service",
                table: "AdditionalServiceRecreationObject",
                column: "RecreationObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseRecreationObject_RecreationObjectsId",
                schema: "recreation_service",
                table: "DiseaseRecreationObject",
                column: "RecreationObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_HealingMethodRecreationObject_RecreationObjectsId",
                schema: "recreation_service",
                table: "HealingMethodRecreationObject",
                column: "RecreationObjectsId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecreationObjects_Location_LocationId",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.DropTable(
                name: "AdditionalServiceRecreationObject",
                schema: "recreation_service");

            migrationBuilder.DropTable(
                name: "DiseaseRecreationObject",
                schema: "recreation_service");

            migrationBuilder.DropTable(
                name: "HealingMethodRecreationObject",
                schema: "recreation_service");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "recreation_service");

            migrationBuilder.DropIndex(
                name: "IX_RecreationObjects_LocationId",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "recreation_service",
                table: "RecreationObjects");

            migrationBuilder.AddColumn<Guid>(
                name: "RecreationObjectId",
                schema: "recreation_service",
                table: "HealingMethods",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecreationObjectId",
                schema: "recreation_service",
                table: "Diseases",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecreationObjectId",
                schema: "recreation_service",
                table: "AdditionalServices",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HealingMethods_RecreationObjectId",
                schema: "recreation_service",
                table: "HealingMethods",
                column: "RecreationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_RecreationObjectId",
                schema: "recreation_service",
                table: "Diseases",
                column: "RecreationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_RecreationObjectId",
                schema: "recreation_service",
                table: "AdditionalServices",
                column: "RecreationObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalServices_RecreationObjects_RecreationObjectId",
                schema: "recreation_service",
                table: "AdditionalServices",
                column: "RecreationObjectId",
                principalSchema: "recreation_service",
                principalTable: "RecreationObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diseases_RecreationObjects_RecreationObjectId",
                schema: "recreation_service",
                table: "Diseases",
                column: "RecreationObjectId",
                principalSchema: "recreation_service",
                principalTable: "RecreationObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HealingMethods_RecreationObjects_RecreationObjectId",
                schema: "recreation_service",
                table: "HealingMethods",
                column: "RecreationObjectId",
                principalSchema: "recreation_service",
                principalTable: "RecreationObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
