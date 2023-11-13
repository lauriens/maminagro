using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class AddingMissingRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landscapes_Municipalities_CityId",
                table: "Landscapes");

            migrationBuilder.DropForeignKey(
                name: "FK_OccurrenceCultures_Occurrences_OccurenceId",
                table: "OccurrenceCultures");

            migrationBuilder.DropForeignKey(
                name: "FK_Occurrences_ColetaMethods_OccurenceMethodId",
                table: "Occurrences");

            migrationBuilder.DropTable(
                name: "BiomeLandscape");

            migrationBuilder.DropIndex(
                name: "IX_Landscapes_CityId",
                table: "Landscapes");

            migrationBuilder.RenameColumn(
                name: "OccurenceMethodId",
                table: "Occurrences",
                newName: "OccurrenceMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Occurrences_OccurenceMethodId",
                table: "Occurrences",
                newName: "IX_Occurrences_OccurrenceMethodId");

            migrationBuilder.RenameColumn(
                name: "OccurenceId",
                table: "OccurrenceCultures",
                newName: "OccurrenceId");

            migrationBuilder.RenameIndex(
                name: "IX_OccurrenceCultures_OccurenceId",
                table: "OccurrenceCultures",
                newName: "IX_OccurrenceCultures_OccurrenceId");

            migrationBuilder.CreateTable(
                name: "BiomeLandscapes",
                columns: table => new
                {
                    BiomeId = table.Column<int>(type: "integer", nullable: false),
                    LandscapeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiomeLandscapes", x => new { x.BiomeId, x.LandscapeId });
                    table.ForeignKey(
                        name: "FK_BiomeLandscapes_Biomes_BiomeId",
                        column: x => x.BiomeId,
                        principalTable: "Biomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BiomeLandscapes_Landscapes_LandscapeId",
                        column: x => x.LandscapeId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandscapeMunicipalities",
                columns: table => new
                {
                    LandscapeId = table.Column<int>(type: "integer", nullable: false),
                    MunicipalityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandscapeMunicipalities", x => new { x.MunicipalityId, x.LandscapeId });
                    table.ForeignKey(
                        name: "FK_LandscapeMunicipalities_Landscapes_LandscapeId",
                        column: x => x.LandscapeId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandscapeMunicipalities_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiomeLandscapes_LandscapeId",
                table: "BiomeLandscapes",
                column: "LandscapeId");

            migrationBuilder.CreateIndex(
                name: "IX_LandscapeMunicipalities_LandscapeId",
                table: "LandscapeMunicipalities",
                column: "LandscapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OccurrenceCultures_Occurrences_OccurrenceId",
                table: "OccurrenceCultures",
                column: "OccurrenceId",
                principalTable: "Occurrences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Occurrences_ColetaMethods_OccurrenceMethodId",
                table: "Occurrences",
                column: "OccurrenceMethodId",
                principalTable: "ColetaMethods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OccurrenceCultures_Occurrences_OccurrenceId",
                table: "OccurrenceCultures");

            migrationBuilder.DropForeignKey(
                name: "FK_Occurrences_ColetaMethods_OccurrenceMethodId",
                table: "Occurrences");

            migrationBuilder.DropTable(
                name: "BiomeLandscapes");

            migrationBuilder.DropTable(
                name: "LandscapeMunicipalities");

            migrationBuilder.RenameColumn(
                name: "OccurrenceMethodId",
                table: "Occurrences",
                newName: "OccurenceMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Occurrences_OccurrenceMethodId",
                table: "Occurrences",
                newName: "IX_Occurrences_OccurenceMethodId");

            migrationBuilder.RenameColumn(
                name: "OccurrenceId",
                table: "OccurrenceCultures",
                newName: "OccurenceId");

            migrationBuilder.RenameIndex(
                name: "IX_OccurrenceCultures_OccurrenceId",
                table: "OccurrenceCultures",
                newName: "IX_OccurrenceCultures_OccurenceId");

            migrationBuilder.CreateTable(
                name: "BiomeLandscape",
                columns: table => new
                {
                    BiomesId = table.Column<int>(type: "integer", nullable: false),
                    LandscapesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiomeLandscape", x => new { x.BiomesId, x.LandscapesId });
                    table.ForeignKey(
                        name: "FK_BiomeLandscape_Biomes_BiomesId",
                        column: x => x.BiomesId,
                        principalTable: "Biomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BiomeLandscape_Landscapes_LandscapesId",
                        column: x => x.LandscapesId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landscapes_CityId",
                table: "Landscapes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BiomeLandscape_LandscapesId",
                table: "BiomeLandscape",
                column: "LandscapesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Landscapes_Municipalities_CityId",
                table: "Landscapes",
                column: "CityId",
                principalTable: "Municipalities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OccurrenceCultures_Occurrences_OccurenceId",
                table: "OccurrenceCultures",
                column: "OccurenceId",
                principalTable: "Occurrences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Occurrences_ColetaMethods_OccurenceMethodId",
                table: "Occurrences",
                column: "OccurenceMethodId",
                principalTable: "ColetaMethods",
                principalColumn: "Id");
        }
    }
}
