using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateMaterialInformationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComsumptionZ",
                table: "MaterialInformation",
                newName: "ConsumptionZ");
            
            migrationBuilder.AlterColumn<double>(
                name: "UnitCover",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "ConsumptionZ",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "ConsumptionX",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "AppliedLayers",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "UnitCover",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "ConsumptionZ",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "ConsumptionX",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "AppliedLayers",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}