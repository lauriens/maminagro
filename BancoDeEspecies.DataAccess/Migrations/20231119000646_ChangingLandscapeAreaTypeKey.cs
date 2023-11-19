using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class ChangingLandscapeAreaTypeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LandscapeAreaTypes",
                table: "LandscapeAreaTypes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "LandscapeAreaTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandscapeAreaTypes",
                table: "LandscapeAreaTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LandscapeAreaTypes_AreaTypeId",
                table: "LandscapeAreaTypes",
                column: "AreaTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LandscapeAreaTypes",
                table: "LandscapeAreaTypes");

            migrationBuilder.DropIndex(
                name: "IX_LandscapeAreaTypes_AreaTypeId",
                table: "LandscapeAreaTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "LandscapeAreaTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandscapeAreaTypes",
                table: "LandscapeAreaTypes",
                columns: new[] { "AreaTypeId", "LandscapeId" });
        }
    }
}
