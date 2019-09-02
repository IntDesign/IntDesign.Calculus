using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class BasicModelsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HousesSet",
                columns: table => new
                {
                    HouseId = table.Column<Guid>(nullable: false),
                    HouseAddress = table.Column<string>(nullable: true),
                    OwnerName = table.Column<string>(nullable: true),
                    OwnerPhone = table.Column<string>(nullable: true),
                    OwnerEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HousesSet", x => x.HouseId);
                });

            migrationBuilder.CreateTable(
                name: "RoomsSet",
                columns: table => new
                {
                    RoomId = table.Column<Guid>(nullable: false),
                    Lenght = table.Column<float>(nullable: false),
                    Widtd = table.Column<float>(nullable: false),
                    Height = table.Column<float>(nullable: false),
                    Asp = table.Column<float>(nullable: false),
                    EmptyAsp = table.Column<float>(nullable: false),
                    Afm = table.Column<float>(nullable: false),
                    SpecialAfm = table.Column<float>(nullable: false),
                    HouseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsSet", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_RoomsSet_HousesSet_HouseId",
                        column: x => x.HouseId,
                        principalTable: "HousesSet",
                        principalColumn: "HouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomWallObjectsSet",
                columns: table => new
                {
                    RoomWallObjectId = table.Column<Guid>(nullable: false),
                    RoomId = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Lenght = table.Column<float>(nullable: false),
                    Width = table.Column<float>(nullable: false),
                    Height = table.Column<float>(nullable: false),
                    Area = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomWallObjectsSet", x => x.RoomWallObjectId);
                    table.ForeignKey(
                        name: "FK_RoomWallObjectsSet_RoomsSet_RoomId",
                        column: x => x.RoomId,
                        principalTable: "RoomsSet",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomJobsSet",
                columns: table => new
                {
                    RoomJobId = table.Column<Guid>(nullable: false),
                    RoomId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    FinishDate = table.Column<DateTime>(nullable: false),
                    MaterialExpenditureId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomJobsSet", x => x.RoomJobId);
                    table.ForeignKey(
                        name: "FK_RoomJobsSet_RoomsSet_RoomId",
                        column: x => x.RoomId,
                        principalTable: "RoomsSet",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialsSet",
                columns: table => new
                {
                    MaterialId = table.Column<Guid>(nullable: false),
                    MaterialName = table.Column<string>(nullable: true),
                    MaterialType = table.Column<int>(nullable: false),
                    PricePerPacket = table.Column<float>(nullable: false),
                    RoomJobId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialsSet", x => x.MaterialId);
                    table.ForeignKey(
                        name: "FK_MaterialsSet_RoomJobsSet_RoomJobId",
                        column: x => x.RoomJobId,
                        principalTable: "RoomJobsSet",
                        principalColumn: "RoomJobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialExpendituresSet",
                columns: table => new
                {
                    MaterialExpenditureId = table.Column<Guid>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false),
                    TotalKilograms = table.Column<float>(nullable: false),
                    TotalPackets = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialExpendituresSet", x => x.MaterialExpenditureId);
                    table.ForeignKey(
                        name: "FK_MaterialExpendituresSet_MaterialsSet_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "MaterialsSet",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialInformationsSet",
                columns: table => new
                {
                    MaterialInformationId = table.Column<Guid>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    AppliedLayers = table.Column<float>(nullable: false),
                    ConsumptionX = table.Column<float>(nullable: false),
                    ComsumptionZ = table.Column<float>(nullable: false),
                    UnitCover = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialInformationsSet", x => x.MaterialInformationId);
                    table.ForeignKey(
                        name: "FK_MaterialInformationsSet_MaterialsSet_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "MaterialsSet",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProvidersSet",
                columns: table => new
                {
                    ProviderId = table.Column<Guid>(nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    ProviderName = table.Column<string>(nullable: true),
                    ProviderAddress = table.Column<string>(nullable: true),
                    ProviderEmail = table.Column<string>(nullable: true),
                    ProviderPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidersSet", x => x.ProviderId);
                    table.ForeignKey(
                        name: "FK_ProvidersSet_MaterialsSet_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "MaterialsSet",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HousesSet_HouseId",
                table: "HousesSet",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialExpendituresSet_MaterialExpenditureId",
                table: "MaterialExpendituresSet",
                column: "MaterialExpenditureId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialExpendituresSet_MaterialId",
                table: "MaterialExpendituresSet",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInformationsSet_MaterialId",
                table: "MaterialInformationsSet",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInformationsSet_MaterialInformationId",
                table: "MaterialInformationsSet",
                column: "MaterialInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialsSet_MaterialId",
                table: "MaterialsSet",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialsSet_RoomJobId",
                table: "MaterialsSet",
                column: "RoomJobId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidersSet_MaterialId",
                table: "ProvidersSet",
                column: "MaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProvidersSet_ProviderId",
                table: "ProvidersSet",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomJobsSet_MaterialExpenditureId",
                table: "RoomJobsSet",
                column: "MaterialExpenditureId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomJobsSet_RoomId",
                table: "RoomJobsSet",
                column: "RoomId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomJobsSet_RoomJobId",
                table: "RoomJobsSet",
                column: "RoomJobId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsSet_HouseId",
                table: "RoomsSet",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsSet_RoomId",
                table: "RoomsSet",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomWallObjectsSet_RoomId",
                table: "RoomWallObjectsSet",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomWallObjectsSet_RoomWallObjectId",
                table: "RoomWallObjectsSet",
                column: "RoomWallObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomJobsSet_MaterialExpendituresSet_MaterialExpenditureId",
                table: "RoomJobsSet",
                column: "MaterialExpenditureId",
                principalTable: "MaterialExpendituresSet",
                principalColumn: "MaterialExpenditureId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialExpendituresSet_MaterialsSet_MaterialId",
                table: "MaterialExpendituresSet");

            migrationBuilder.DropTable(
                name: "MaterialInformationsSet");

            migrationBuilder.DropTable(
                name: "ProvidersSet");

            migrationBuilder.DropTable(
                name: "RoomWallObjectsSet");

            migrationBuilder.DropTable(
                name: "MaterialsSet");

            migrationBuilder.DropTable(
                name: "RoomJobsSet");

            migrationBuilder.DropTable(
                name: "MaterialExpendituresSet");

            migrationBuilder.DropTable(
                name: "RoomsSet");

            migrationBuilder.DropTable(
                name: "HousesSet");
        }
    }
}
