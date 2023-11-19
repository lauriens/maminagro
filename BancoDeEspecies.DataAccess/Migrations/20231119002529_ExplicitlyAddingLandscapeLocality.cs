using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class ExplicitlyAddingLandscapeLocality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandscapeLocality");

            migrationBuilder.CreateTable(
                name: "LandscapeLocalities",
                columns: table => new
                {
                    LandscapeId = table.Column<int>(type: "integer", nullable: false),
                    LocalityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandscapeLocalities", x => new { x.LocalityId, x.LandscapeId });
                    table.ForeignKey(
                        name: "FK_LandscapeLocalities_Landscapes_LandscapeId",
                        column: x => x.LandscapeId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandscapeLocalities_Localities_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Localities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandscapeLocalities_LandscapeId",
                table: "LandscapeLocalities",
                column: "LandscapeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandscapeLocalities");

            migrationBuilder.CreateTable(
                name: "LandscapeLocality",
                columns: table => new
                {
                    LandscapesId = table.Column<int>(type: "integer", nullable: false),
                    LocalitiesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandscapeLocality", x => new { x.LandscapesId, x.LocalitiesId });
                    table.ForeignKey(
                        name: "FK_LandscapeLocality_Landscapes_LandscapesId",
                        column: x => x.LandscapesId,
                        principalTable: "Landscapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandscapeLocality_Localities_LocalitiesId",
                        column: x => x.LocalitiesId,
                        principalTable: "Localities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandscapeLocality_LocalitiesId",
                table: "LandscapeLocality",
                column: "LocalitiesId");
        }
    }
}
