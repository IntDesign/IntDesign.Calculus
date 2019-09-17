using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateTableRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomJobs_RoomId",
                table: "RoomJobs");

            migrationBuilder.CreateIndex(
                name: "IX_RoomJobs_RoomId",
                table: "RoomJobs",
                column: "RoomId");
            
            migrationBuilder.AddForeignKey(
                name: "FK_RoomJobs_Rooms_RoomId",
                table: "RoomJobs",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomJobs_RoomId",
                table: "RoomJobs");

            migrationBuilder.CreateIndex(
                name: "IX_RoomJobs_RoomId",
                table: "RoomJobs",
                column: "RoomId",
                unique: true);
        }
    }
}
