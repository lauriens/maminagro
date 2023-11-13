using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class AddingAgroecosystemLandscapeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landscapes_Agroecosystems_AgroecosystemId",
                table: "Landscapes");

            migrationBuilder.AddForeignKey(
                name: "FK_Landscapes_Agroecosystems_AgroecosystemId",
                table: "Landscapes",
                column: "AgroecosystemId",
                principalTable: "Agroecosystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landscapes_Agroecosystems_AgroecosystemId",
                table: "Landscapes");

            migrationBuilder.AddForeignKey(
                name: "FK_Landscapes_Agroecosystems_AgroecosystemId",
                table: "Landscapes",
                column: "AgroecosystemId",
                principalTable: "Agroecosystems",
                principalColumn: "Id");
        }
    }
}
