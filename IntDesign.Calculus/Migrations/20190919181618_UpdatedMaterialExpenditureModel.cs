using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdatedMaterialExpenditureModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialExpenditures_Materials_MaterialId",
                table: "MaterialExpenditures");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "MaterialExpenditures",
                newName: "MaterialInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpenditures_MaterialId",
                table: "MaterialExpenditures",
                newName: "IX_MaterialExpenditures_MaterialInformationId");

            migrationBuilder.AddColumn<double>(
                name: "ProductQuantity",
                table: "MaterialInformation",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialExpenditures_MaterialInformation_MaterialInformation~",
                table: "MaterialExpenditures",
                column: "MaterialInformationId",
                principalTable: "MaterialInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialExpenditures_MaterialInformation_MaterialInformation~",
                table: "MaterialExpenditures");

            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "MaterialInformation");

            migrationBuilder.RenameColumn(
                name: "MaterialInformationId",
                table: "MaterialExpenditures",
                newName: "MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpenditures_MaterialInformationId",
                table: "MaterialExpenditures",
                newName: "IX_MaterialExpenditures_MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialExpenditures_Materials_MaterialId",
                table: "MaterialExpenditures",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
