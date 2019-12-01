using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculus.Migrations
{
    public partial class FixedMaterialFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialInformation_Providers_ProviderId",
                table: "MaterialInformation");

            migrationBuilder.DropColumn(
                name: "PricePerPacket",
                table: "MaterialExpenditures");

            migrationBuilder.DropColumn(
                name: "TotalKilograms",
                table: "MaterialExpenditures");

            migrationBuilder.AlterColumn<double>(
                name: "UnitCover",
                table: "MaterialInformation",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProviderId",
                table: "MaterialInformation",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<double>(
                name: "ProductQuantity",
                table: "MaterialInformation",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ConsumptionZ",
                table: "MaterialInformation",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ConsumptionX",
                table: "MaterialInformation",
                nullable: true,
                oldClrType: typeof(double),
                defaultValue: 1);

            migrationBuilder.AlterColumn<double>(
                name: "AppliedLayers",
                table: "MaterialInformation",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<double>(
                name: "PricePerUnit",
                table: "MaterialInformation",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "MaterialExpenditures",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "TotalPackets",
                table: "MaterialExpenditures",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<double>(
                name: "TotalQuantity",
                table: "MaterialExpenditures",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialInformation_Providers_ProviderId",
                table: "MaterialInformation",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialInformation_Providers_ProviderId",
                table: "MaterialInformation");

            migrationBuilder.DropColumn(
                name: "PricePerUnit",
                table: "MaterialInformation");

            migrationBuilder.DropColumn(
                name: "TotalQuantity",
                table: "MaterialExpenditures");

            migrationBuilder.AlterColumn<double>(
                name: "UnitCover",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProviderId",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ProductQuantity",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ConsumptionZ",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ConsumptionX",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AppliedLayers",
                table: "MaterialInformation",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "TotalPrice",
                table: "MaterialExpenditures",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "TotalPackets",
                table: "MaterialExpenditures",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PricePerPacket",
                table: "MaterialExpenditures",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalKilograms",
                table: "MaterialExpenditures",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialInformation_Providers_ProviderId",
                table: "MaterialInformation",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
