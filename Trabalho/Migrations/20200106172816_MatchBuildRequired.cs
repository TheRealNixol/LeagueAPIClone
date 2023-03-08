using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class MatchBuildRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_MatchBuilds_BuildId",
                table: "MatchPlayers");

            migrationBuilder.AlterColumn<int>(
                name: "BuildId",
                table: "MatchPlayers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_MatchBuilds_BuildId",
                table: "MatchPlayers",
                column: "BuildId",
                principalTable: "MatchBuilds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_MatchBuilds_BuildId",
                table: "MatchPlayers");

            migrationBuilder.AlterColumn<int>(
                name: "BuildId",
                table: "MatchPlayers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_MatchBuilds_BuildId",
                table: "MatchPlayers",
                column: "BuildId",
                principalTable: "MatchBuilds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
