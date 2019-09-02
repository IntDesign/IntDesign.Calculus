using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class UpdatedIdType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomWallObjectId",
                table: "RoomWallObjects",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_RoomWallObjects_RoomWallObjectId",
                table: "RoomWallObjects",
                newName: "IX_RoomWallObjects_Id");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomId",
                table: "Rooms",
                newName: "IX_Rooms_Id");

            migrationBuilder.RenameColumn(
                name: "RoomJobId",
                table: "RoomJobs",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobs_RoomJobId",
                table: "RoomJobs",
                newName: "IX_RoomJobs_Id");

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "Providers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Providers_ProviderId",
                table: "Providers",
                newName: "IX_Providers_Id");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "Materials",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_MaterialId",
                table: "Materials",
                newName: "IX_Materials_Id");

            migrationBuilder.RenameColumn(
                name: "MaterialInformationId",
                table: "MaterialInformations",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInformations_MaterialInformationId",
                table: "MaterialInformations",
                newName: "IX_MaterialInformations_Id");

            migrationBuilder.RenameColumn(
                name: "MaterialExpenditureId",
                table: "MaterialExpenditures",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpenditures_MaterialExpenditureId",
                table: "MaterialExpenditures",
                newName: "IX_MaterialExpenditures_Id");

            migrationBuilder.RenameColumn(
                name: "HouseId",
                table: "Houses",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Houses_HouseId",
                table: "Houses",
                newName: "IX_Houses_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoomWallObjects",
                newName: "RoomWallObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomWallObjects_Id",
                table: "RoomWallObjects",
                newName: "IX_RoomWallObjects_RoomWallObjectId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_Id",
                table: "Rooms",
                newName: "IX_Rooms_RoomId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoomJobs",
                newName: "RoomJobId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobs_Id",
                table: "RoomJobs",
                newName: "IX_RoomJobs_RoomJobId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Providers",
                newName: "ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Providers_Id",
                table: "Providers",
                newName: "IX_Providers_ProviderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Materials",
                newName: "MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_Id",
                table: "Materials",
                newName: "IX_Materials_MaterialId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MaterialInformations",
                newName: "MaterialInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInformations_Id",
                table: "MaterialInformations",
                newName: "IX_MaterialInformations_MaterialInformationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MaterialExpenditures",
                newName: "MaterialExpenditureId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpenditures_Id",
                table: "MaterialExpenditures",
                newName: "IX_MaterialExpenditures_MaterialExpenditureId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Houses",
                newName: "HouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Houses_Id",
                table: "Houses",
                newName: "IX_Houses_HouseId");
        }
    }
}
