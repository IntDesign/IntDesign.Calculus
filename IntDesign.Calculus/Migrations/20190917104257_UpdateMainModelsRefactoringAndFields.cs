using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateMainModelsRefactoringAndFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialInformations");

            migrationBuilder.RenameColumn(
                name: "Widtd",
                table: "Rooms",
                newName: "Width");

            migrationBuilder.AddColumn<float>(
                name: "Atv",
                table: "Rooms",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pc",
                table: "Rooms",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "MaterialInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    AppliedLayers = table.Column<float>(nullable: false),
                    ConsumptionX = table.Column<float>(nullable: false),
                    ComsumptionZ = table.Column<float>(nullable: false),
                    UnitCover = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialInformation_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInformation_Id",
                table: "MaterialInformation",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInformation_MaterialId",
                table: "MaterialInformation",
                column: "MaterialId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialInformation");

            migrationBuilder.DropColumn(
                name: "Atv",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Pc",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "Rooms",
                newName: "Widtd");

            migrationBuilder.CreateTable(
                name: "MaterialInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AppliedLayers = table.Column<float>(nullable: false),
                    ComsumptionZ = table.Column<float>(nullable: false),
                    ConsumptionX = table.Column<float>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    UnitCover = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialInformations_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInformations_Id",
                table: "MaterialInformations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInformations_MaterialId",
                table: "MaterialInformations",
                column: "MaterialId",
                unique: true);
        }
    }
}
