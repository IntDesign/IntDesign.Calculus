using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class BasicModelsAddedUpdatedNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialExpendituresSet_MaterialsSet_MaterialId",
                table: "MaterialExpendituresSet");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialInformationsSet_MaterialsSet_MaterialId",
                table: "MaterialInformationsSet");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialsSet_RoomJobsSet_RoomJobId",
                table: "MaterialsSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidersSet_MaterialsSet_MaterialId",
                table: "ProvidersSet");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomJobsSet_MaterialExpendituresSet_MaterialExpenditureId",
                table: "RoomJobsSet");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomJobsSet_RoomsSet_RoomId",
                table: "RoomJobsSet");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomsSet_HousesSet_HouseId",
                table: "RoomsSet");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomWallObjectsSet_RoomsSet_RoomId",
                table: "RoomWallObjectsSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomWallObjectsSet",
                table: "RoomWallObjectsSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomsSet",
                table: "RoomsSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomJobsSet",
                table: "RoomJobsSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProvidersSet",
                table: "ProvidersSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialsSet",
                table: "MaterialsSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialInformationsSet",
                table: "MaterialInformationsSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialExpendituresSet",
                table: "MaterialExpendituresSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HousesSet",
                table: "HousesSet");

            migrationBuilder.RenameTable(
                name: "RoomWallObjectsSet",
                newName: "RoomWallObjects");

            migrationBuilder.RenameTable(
                name: "RoomsSet",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "RoomJobsSet",
                newName: "RoomJobs");

            migrationBuilder.RenameTable(
                name: "ProvidersSet",
                newName: "Providers");

            migrationBuilder.RenameTable(
                name: "MaterialsSet",
                newName: "Materials");

            migrationBuilder.RenameTable(
                name: "MaterialInformationsSet",
                newName: "MaterialInformations");

            migrationBuilder.RenameTable(
                name: "MaterialExpendituresSet",
                newName: "MaterialExpenditures");

            migrationBuilder.RenameTable(
                name: "HousesSet",
                newName: "Houses");

            migrationBuilder.RenameIndex(
                name: "IX_RoomWallObjectsSet_RoomWallObjectId",
                table: "RoomWallObjects",
                newName: "IX_RoomWallObjects_RoomWallObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomWallObjectsSet_RoomId",
                table: "RoomWallObjects",
                newName: "IX_RoomWallObjects_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomsSet_RoomId",
                table: "Rooms",
                newName: "IX_Rooms_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomsSet_HouseId",
                table: "Rooms",
                newName: "IX_Rooms_HouseId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobsSet_RoomJobId",
                table: "RoomJobs",
                newName: "IX_RoomJobs_RoomJobId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobsSet_RoomId",
                table: "RoomJobs",
                newName: "IX_RoomJobs_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobsSet_MaterialExpenditureId",
                table: "RoomJobs",
                newName: "IX_RoomJobs_MaterialExpenditureId");

            migrationBuilder.RenameIndex(
                name: "IX_ProvidersSet_ProviderId",
                table: "Providers",
                newName: "IX_Providers_ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_ProvidersSet_MaterialId",
                table: "Providers",
                newName: "IX_Providers_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialsSet_RoomJobId",
                table: "Materials",
                newName: "IX_Materials_RoomJobId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialsSet_MaterialId",
                table: "Materials",
                newName: "IX_Materials_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInformationsSet_MaterialInformationId",
                table: "MaterialInformations",
                newName: "IX_MaterialInformations_MaterialInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInformationsSet_MaterialId",
                table: "MaterialInformations",
                newName: "IX_MaterialInformations_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpendituresSet_MaterialId",
                table: "MaterialExpenditures",
                newName: "IX_MaterialExpenditures_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpendituresSet_MaterialExpenditureId",
                table: "MaterialExpenditures",
                newName: "IX_MaterialExpenditures_MaterialExpenditureId");

            migrationBuilder.RenameIndex(
                name: "IX_HousesSet_HouseId",
                table: "Houses",
                newName: "IX_Houses_HouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomWallObjects",
                table: "RoomWallObjects",
                column: "RoomWallObjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "RoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomJobs",
                table: "RoomJobs",
                column: "RoomJobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providers",
                table: "Providers",
                column: "ProviderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "MaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialInformations",
                table: "MaterialInformations",
                column: "MaterialInformationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialExpenditures",
                table: "MaterialExpenditures",
                column: "MaterialExpenditureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Houses",
                table: "Houses",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialExpenditures_Materials_MaterialId",
                table: "MaterialExpenditures",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialInformations_Materials_MaterialId",
                table: "MaterialInformations",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_RoomJobs_RoomJobId",
                table: "Materials",
                column: "RoomJobId",
                principalTable: "RoomJobs",
                principalColumn: "RoomJobId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_Materials_MaterialId",
                table: "Providers",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomJobs_MaterialExpenditures_MaterialExpenditureId",
                table: "RoomJobs",
                column: "MaterialExpenditureId",
                principalTable: "MaterialExpenditures",
                principalColumn: "MaterialExpenditureId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomJobs_Rooms_RoomId",
                table: "RoomJobs",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Houses_HouseId",
                table: "Rooms",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "HouseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomWallObjects_Rooms_RoomId",
                table: "RoomWallObjects",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialExpenditures_Materials_MaterialId",
                table: "MaterialExpenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialInformations_Materials_MaterialId",
                table: "MaterialInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_RoomJobs_RoomJobId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Materials_MaterialId",
                table: "Providers");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomJobs_MaterialExpenditures_MaterialExpenditureId",
                table: "RoomJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomJobs_Rooms_RoomId",
                table: "RoomJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Houses_HouseId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomWallObjects_Rooms_RoomId",
                table: "RoomWallObjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomWallObjects",
                table: "RoomWallObjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomJobs",
                table: "RoomJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providers",
                table: "Providers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialInformations",
                table: "MaterialInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialExpenditures",
                table: "MaterialExpenditures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Houses",
                table: "Houses");

            migrationBuilder.RenameTable(
                name: "RoomWallObjects",
                newName: "RoomWallObjectsSet");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "RoomsSet");

            migrationBuilder.RenameTable(
                name: "RoomJobs",
                newName: "RoomJobsSet");

            migrationBuilder.RenameTable(
                name: "Providers",
                newName: "ProvidersSet");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "MaterialsSet");

            migrationBuilder.RenameTable(
                name: "MaterialInformations",
                newName: "MaterialInformationsSet");

            migrationBuilder.RenameTable(
                name: "MaterialExpenditures",
                newName: "MaterialExpendituresSet");

            migrationBuilder.RenameTable(
                name: "Houses",
                newName: "HousesSet");

            migrationBuilder.RenameIndex(
                name: "IX_RoomWallObjects_RoomWallObjectId",
                table: "RoomWallObjectsSet",
                newName: "IX_RoomWallObjectsSet_RoomWallObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomWallObjects_RoomId",
                table: "RoomWallObjectsSet",
                newName: "IX_RoomWallObjectsSet_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomId",
                table: "RoomsSet",
                newName: "IX_RoomsSet_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HouseId",
                table: "RoomsSet",
                newName: "IX_RoomsSet_HouseId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobs_RoomJobId",
                table: "RoomJobsSet",
                newName: "IX_RoomJobsSet_RoomJobId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobs_RoomId",
                table: "RoomJobsSet",
                newName: "IX_RoomJobsSet_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_RoomJobs_MaterialExpenditureId",
                table: "RoomJobsSet",
                newName: "IX_RoomJobsSet_MaterialExpenditureId");

            migrationBuilder.RenameIndex(
                name: "IX_Providers_ProviderId",
                table: "ProvidersSet",
                newName: "IX_ProvidersSet_ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Providers_MaterialId",
                table: "ProvidersSet",
                newName: "IX_ProvidersSet_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_RoomJobId",
                table: "MaterialsSet",
                newName: "IX_MaterialsSet_RoomJobId");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_MaterialId",
                table: "MaterialsSet",
                newName: "IX_MaterialsSet_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInformations_MaterialInformationId",
                table: "MaterialInformationsSet",
                newName: "IX_MaterialInformationsSet_MaterialInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInformations_MaterialId",
                table: "MaterialInformationsSet",
                newName: "IX_MaterialInformationsSet_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpenditures_MaterialId",
                table: "MaterialExpendituresSet",
                newName: "IX_MaterialExpendituresSet_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialExpenditures_MaterialExpenditureId",
                table: "MaterialExpendituresSet",
                newName: "IX_MaterialExpendituresSet_MaterialExpenditureId");

            migrationBuilder.RenameIndex(
                name: "IX_Houses_HouseId",
                table: "HousesSet",
                newName: "IX_HousesSet_HouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomWallObjectsSet",
                table: "RoomWallObjectsSet",
                column: "RoomWallObjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomsSet",
                table: "RoomsSet",
                column: "RoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomJobsSet",
                table: "RoomJobsSet",
                column: "RoomJobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProvidersSet",
                table: "ProvidersSet",
                column: "ProviderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialsSet",
                table: "MaterialsSet",
                column: "MaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialInformationsSet",
                table: "MaterialInformationsSet",
                column: "MaterialInformationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialExpendituresSet",
                table: "MaterialExpendituresSet",
                column: "MaterialExpenditureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HousesSet",
                table: "HousesSet",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialExpendituresSet_MaterialsSet_MaterialId",
                table: "MaterialExpendituresSet",
                column: "MaterialId",
                principalTable: "MaterialsSet",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialInformationsSet_MaterialsSet_MaterialId",
                table: "MaterialInformationsSet",
                column: "MaterialId",
                principalTable: "MaterialsSet",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialsSet_RoomJobsSet_RoomJobId",
                table: "MaterialsSet",
                column: "RoomJobId",
                principalTable: "RoomJobsSet",
                principalColumn: "RoomJobId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidersSet_MaterialsSet_MaterialId",
                table: "ProvidersSet",
                column: "MaterialId",
                principalTable: "MaterialsSet",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomJobsSet_MaterialExpendituresSet_MaterialExpenditureId",
                table: "RoomJobsSet",
                column: "MaterialExpenditureId",
                principalTable: "MaterialExpendituresSet",
                principalColumn: "MaterialExpenditureId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomJobsSet_RoomsSet_RoomId",
                table: "RoomJobsSet",
                column: "RoomId",
                principalTable: "RoomsSet",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomsSet_HousesSet_HouseId",
                table: "RoomsSet",
                column: "HouseId",
                principalTable: "HousesSet",
                principalColumn: "HouseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomWallObjectsSet_RoomsSet_RoomId",
                table: "RoomWallObjectsSet",
                column: "RoomId",
                principalTable: "RoomsSet",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
