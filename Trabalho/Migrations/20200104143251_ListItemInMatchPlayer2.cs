using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class ListItemInMatchPlayer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_MatchPlayers_MatchPlayerId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_MatchPlayerId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MatchPlayerId",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "Build",
                table: "MatchPlayers",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Build",
                table: "MatchPlayers");

            migrationBuilder.AddColumn<int>(
                name: "MatchPlayerId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_MatchPlayerId",
                table: "Items",
                column: "MatchPlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_MatchPlayers_MatchPlayerId",
                table: "Items",
                column: "MatchPlayerId",
                principalTable: "MatchPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
