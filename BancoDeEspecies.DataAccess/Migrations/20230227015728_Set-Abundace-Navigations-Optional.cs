using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class SetAbundaceNavigationsOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abundances_Landscapes_LandscapeId",
                table: "Abundances");

            migrationBuilder.DropForeignKey(
                name: "FK_Abundances_Occurrences_OccurrenceId",
                table: "Abundances");

            migrationBuilder.AlterColumn<int>(
                name: "OccurrenceId",
                table: "Abundances",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "LandscapeId",
                table: "Abundances",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Abundances_Landscapes_LandscapeId",
                table: "Abundances",
                column: "LandscapeId",
                principalTable: "Landscapes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abundances_Occurrences_OccurrenceId",
                table: "Abundances",
                column: "OccurrenceId",
                principalTable: "Occurrences",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abundances_Landscapes_LandscapeId",
                table: "Abundances");

            migrationBuilder.DropForeignKey(
                name: "FK_Abundances_Occurrences_OccurrenceId",
                table: "Abundances");

            migrationBuilder.AlterColumn<int>(
                name: "OccurrenceId",
                table: "Abundances",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LandscapeId",
                table: "Abundances",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abundances_Landscapes_LandscapeId",
                table: "Abundances",
                column: "LandscapeId",
                principalTable: "Landscapes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abundances_Occurrences_OccurrenceId",
                table: "Abundances",
                column: "OccurrenceId",
                principalTable: "Occurrences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
