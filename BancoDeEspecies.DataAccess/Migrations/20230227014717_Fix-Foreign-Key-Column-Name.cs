using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class FixForeignKeyColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occurrences_Species_SpeciesId",
                table: "Occurrences");

            migrationBuilder.RenameColumn(
                name: "SpeciesId",
                table: "Occurrences",
                newName: "SpecieId");

            migrationBuilder.RenameIndex(
                name: "IX_Occurrences_SpeciesId",
                table: "Occurrences",
                newName: "IX_Occurrences_SpecieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occurrences_Species_SpecieId",
                table: "Occurrences",
                column: "SpecieId",
                principalTable: "Species",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occurrences_Species_SpecieId",
                table: "Occurrences");

            migrationBuilder.RenameColumn(
                name: "SpecieId",
                table: "Occurrences",
                newName: "SpeciesId");

            migrationBuilder.RenameIndex(
                name: "IX_Occurrences_SpecieId",
                table: "Occurrences",
                newName: "IX_Occurrences_SpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occurrences_Species_SpeciesId",
                table: "Occurrences",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id");
        }
    }
}
