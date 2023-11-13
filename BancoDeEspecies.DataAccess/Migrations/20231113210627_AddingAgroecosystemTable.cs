using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class AddingAgroecosystemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agroecosystem",
                table: "Landscapes");

            migrationBuilder.AddColumn<int>(
                name: "AgroecosystemId",
                table: "Landscapes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agroecosystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Abbreviation = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agroecosystems", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landscapes_AgroecosystemId",
                table: "Landscapes",
                column: "AgroecosystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Landscapes_Agroecosystems_AgroecosystemId",
                table: "Landscapes",
                column: "AgroecosystemId",
                principalTable: "Agroecosystems",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landscapes_Agroecosystems_AgroecosystemId",
                table: "Landscapes");

            migrationBuilder.DropTable(
                name: "Agroecosystems");

            migrationBuilder.DropIndex(
                name: "IX_Landscapes_AgroecosystemId",
                table: "Landscapes");

            migrationBuilder.DropColumn(
                name: "AgroecosystemId",
                table: "Landscapes");

            migrationBuilder.AddColumn<int>(
                name: "Agroecosystem",
                table: "Landscapes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
