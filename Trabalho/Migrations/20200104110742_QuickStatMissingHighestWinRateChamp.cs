using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class QuickStatMissingHighestWinRateChamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighestWinRateChamp",
                table: "IngameAccountQuickStats");

            migrationBuilder.AddColumn<int>(
                name: "HighestWinRateChampId",
                table: "IngameAccountQuickStats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IngameAccountQuickStats_HighestWinRateChampId",
                table: "IngameAccountQuickStats",
                column: "HighestWinRateChampId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngameAccountQuickStats_Champions_HighestWinRateChampId",
                table: "IngameAccountQuickStats",
                column: "HighestWinRateChampId",
                principalTable: "Champions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngameAccountQuickStats_Champions_HighestWinRateChampId",
                table: "IngameAccountQuickStats");

            migrationBuilder.DropIndex(
                name: "IX_IngameAccountQuickStats_HighestWinRateChampId",
                table: "IngameAccountQuickStats");

            migrationBuilder.DropColumn(
                name: "HighestWinRateChampId",
                table: "IngameAccountQuickStats");

            migrationBuilder.AddColumn<int>(
                name: "HighestWinRateChamp",
                table: "IngameAccountQuickStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
