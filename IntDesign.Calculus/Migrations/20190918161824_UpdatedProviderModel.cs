using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdatedProviderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Materials_MaterialId",
                table: "Providers");
            
            migrationBuilder.DropIndex(
                name: "IX_Providers_MaterialId",
                table: "Providers");
            
            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Providers");
            
            migrationBuilder.AddColumn<Guid>(
                name: "ProviderId",
                table: "MaterialInformation",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialInformation_Providers_ProviderId",
                table: "MaterialInformation",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInformation_ProviderId",
                table: "MaterialInformation",
                column: "ProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Providers_MaterialInformation_ProviderId",
                table: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_MaterialInformation_ProviderId",
                table: "MaterialInformation");
    
            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "MaterialInformation");
        }
    }
}