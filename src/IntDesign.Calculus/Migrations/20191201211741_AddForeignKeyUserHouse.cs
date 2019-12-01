using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class AddForeignKeyUserHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Users_UserId",
                table: "Houses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Users_UserId",
                table: "Houses");
        }
    }
}