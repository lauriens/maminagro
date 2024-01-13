using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class AddingReferenceTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReferenceId",
                table: "References",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "References",
                newName: "ReferenceId");
        }
    }
}
