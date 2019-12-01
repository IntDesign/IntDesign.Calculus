using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateEnumConversionTypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "RoomWallObjects",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "Invalid");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Rooms",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "Invalid");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "RoomJobs",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "Invalid");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Materials",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "Invalid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "RoomWallObjects",
                nullable: false,
                defaultValue: "Invalid",
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Rooms",
                nullable: false,
                defaultValue: "Invalid",
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "RoomJobs",
                nullable: false,
                defaultValue: "Invalid",
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Materials",
                nullable: false,
                defaultValue: "Invalid",
                oldClrType: typeof(string),
                oldType: "varchar(40)");
        }
    }
}
