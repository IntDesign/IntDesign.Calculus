using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class BasicModelsAddedV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomJobs_MaterialExpenditures_MaterialExpenditureId",
                table: "RoomJobs");

            migrationBuilder.DropIndex(
                name: "IX_RoomJobs_MaterialExpenditureId",
                table: "RoomJobs");

            migrationBuilder.DropColumn(
                name: "MaterialExpenditureId",
                table: "RoomJobs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MaterialExpenditureId",
                table: "RoomJobs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomJobs_MaterialExpenditureId",
                table: "RoomJobs",
                column: "MaterialExpenditureId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomJobs_MaterialExpenditures_MaterialExpenditureId",
                table: "RoomJobs",
                column: "MaterialExpenditureId",
                principalTable: "MaterialExpenditures",
                principalColumn: "MaterialExpenditureId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
