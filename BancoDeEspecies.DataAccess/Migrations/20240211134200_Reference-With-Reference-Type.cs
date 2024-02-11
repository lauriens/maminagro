using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class ReferenceWithReferenceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_References_ReferenceTypes_ReferenceTypeId",
                table: "References");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceTypeId",
                table: "References",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_References_ReferenceTypes_ReferenceTypeId",
                table: "References",
                column: "ReferenceTypeId",
                principalTable: "ReferenceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_References_ReferenceTypes_ReferenceTypeId",
                table: "References");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceTypeId",
                table: "References",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_References_ReferenceTypes_ReferenceTypeId",
                table: "References",
                column: "ReferenceTypeId",
                principalTable: "ReferenceTypes",
                principalColumn: "Id");
        }
    }
}
