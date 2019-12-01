using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateEnumConversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialType",
                table: "Materials");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "RoomWallObjects",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Rooms",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "RoomJobs",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Materials",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "RoomJobs");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Materials");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "RoomWallObjects",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "Invalid");

            migrationBuilder.AddColumn<int>(
                name: "MaterialType",
                table: "Materials",
                nullable: false,
                defaultValue: 0);
        }
    }
}
