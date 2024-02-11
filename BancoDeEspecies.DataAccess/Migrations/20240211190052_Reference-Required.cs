using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class ReferenceRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyCollectMethods_References_ReferenceId",
                table: "StudyCollectMethods");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceId",
                table: "StudyCollectMethods",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudyCollectMethods_References_ReferenceId",
                table: "StudyCollectMethods",
                column: "ReferenceId",
                principalTable: "References",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyCollectMethods_References_ReferenceId",
                table: "StudyCollectMethods");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceId",
                table: "StudyCollectMethods",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyCollectMethods_References_ReferenceId",
                table: "StudyCollectMethods",
                column: "ReferenceId",
                principalTable: "References",
                principalColumn: "Id");
        }
    }
}
