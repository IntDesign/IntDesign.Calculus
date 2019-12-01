using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateRoomModelToComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "SpecialAfm",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "Afm",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<float>(
                name: "CustomHeightOne",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "CustomHeightTwo",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "CustomLenght",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "CustomWidth",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SpecialTilesParquetCoefficient",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TilesParquetCoefficient",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "WallRealCoefficient",
                table: "Rooms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomHeightOne",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CustomHeightTwo",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CustomLenght",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CustomWidth",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SpecialTilesParquetCoefficient",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "TilesParquetCoefficient",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "WallRealCoefficient",
                table: "Rooms");

            migrationBuilder.AlterColumn<float>(
                name: "SpecialAfm",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Afm",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);
        }
    }
}
