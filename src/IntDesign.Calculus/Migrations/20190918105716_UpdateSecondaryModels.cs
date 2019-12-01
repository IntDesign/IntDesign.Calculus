using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateSecondaryModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerPacket",
                table: "Materials");
            
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Materials");

            migrationBuilder.AddColumn<float>(
                name: "PricePerPacket",
                table: "MaterialExpenditures",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerPacket",
                table: "MaterialExpenditures");

            migrationBuilder.AddColumn<float>(
                name: "PricePerPacket",
                table: "Materials",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
