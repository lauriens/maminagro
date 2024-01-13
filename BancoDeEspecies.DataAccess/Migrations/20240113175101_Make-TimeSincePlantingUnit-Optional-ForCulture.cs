using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoDeEspecies.DataAccess.Migrations
{
    public partial class MakeTimeSincePlantingUnitOptionalForCulture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeSincePlantingUnit",
                table: "Cultures",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeSincePlantingUnit",
                table: "Cultures",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }
    }
}
