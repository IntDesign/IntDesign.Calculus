using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdateConectionBetweenMainModelsAndSecondaryModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_RoomJobs_RoomJobId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "RoomJobId",
                table: "Materials"
            );
            
            migrationBuilder.AddColumn<Guid>(
                name: "RoomJobId",
                table: "Materials",
                nullable: false
            );

        migrationBuilder.AddForeignKey(
                name: "FK_Materials_RoomJobs_RoomJobId",
                table: "Materials",
                column: "RoomJobId",
                principalTable: "RoomJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_RoomJobs_RoomJobId",
                table: "Materials");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomJobId",
                table: "Materials",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_RoomJobs_RoomJobId",
                table: "Materials",
                column: "RoomJobId",
                principalTable: "RoomJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
