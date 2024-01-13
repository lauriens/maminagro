using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class MakeSampleAreaOptionalForLandscape : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landscapes_SampleAreaTypes_SampleAreaTypeId",
                table: "Landscapes");

            migrationBuilder.AlterColumn<int>(
                name: "SampleAreaTypeId",
                table: "Landscapes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Landscapes_SampleAreaTypes_SampleAreaTypeId",
                table: "Landscapes",
                column: "SampleAreaTypeId",
                principalTable: "SampleAreaTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landscapes_SampleAreaTypes_SampleAreaTypeId",
                table: "Landscapes");

            migrationBuilder.AlterColumn<int>(
                name: "SampleAreaTypeId",
                table: "Landscapes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Landscapes_SampleAreaTypes_SampleAreaTypeId",
                table: "Landscapes",
                column: "SampleAreaTypeId",
                principalTable: "SampleAreaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
