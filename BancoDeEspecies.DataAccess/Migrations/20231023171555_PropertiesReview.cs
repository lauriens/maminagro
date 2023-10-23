using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class PropertiesReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThreatDegrees_Species_SpeciesId",
                table: "ThreatDegrees");

            migrationBuilder.RenameColumn(
                name: "SpeciesId",
                table: "ThreatDegrees",
                newName: "SpecieId");

            migrationBuilder.RenameIndex(
                name: "IX_ThreatDegrees_SpeciesId",
                table: "ThreatDegrees",
                newName: "IX_ThreatDegrees_SpecieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThreatDegrees_Species_SpecieId",
                table: "ThreatDegrees",
                column: "SpecieId",
                principalTable: "Species",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThreatDegrees_Species_SpecieId",
                table: "ThreatDegrees");

            migrationBuilder.RenameColumn(
                name: "SpecieId",
                table: "ThreatDegrees",
                newName: "SpeciesId");

            migrationBuilder.RenameIndex(
                name: "IX_ThreatDegrees_SpecieId",
                table: "ThreatDegrees",
                newName: "IX_ThreatDegrees_SpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThreatDegrees_Species_SpeciesId",
                table: "ThreatDegrees",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id");
        }
    }
}
