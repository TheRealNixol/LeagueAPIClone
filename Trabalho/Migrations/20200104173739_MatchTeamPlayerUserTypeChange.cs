using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class MatchTeamPlayerUserTypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_Users_UserId",
                table: "MatchPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_Users_User1Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_Users_User2Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_Users_User3Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_Users_User4Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_Users_User5Id",
                table: "MatchTeams");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_IngameAccounts_UserId",
                table: "MatchPlayers",
                column: "UserId",
                principalTable: "IngameAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User1Id",
                table: "MatchTeams",
                column: "User1Id",
                principalTable: "IngameAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User2Id",
                table: "MatchTeams",
                column: "User2Id",
                principalTable: "IngameAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User3Id",
                table: "MatchTeams",
                column: "User3Id",
                principalTable: "IngameAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User4Id",
                table: "MatchTeams",
                column: "User4Id",
                principalTable: "IngameAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User5Id",
                table: "MatchTeams",
                column: "User5Id",
                principalTable: "IngameAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_IngameAccounts_UserId",
                table: "MatchPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User1Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User2Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User3Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User4Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_IngameAccounts_User5Id",
                table: "MatchTeams");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_Users_UserId",
                table: "MatchPlayers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_Users_User1Id",
                table: "MatchTeams",
                column: "User1Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_Users_User2Id",
                table: "MatchTeams",
                column: "User2Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_Users_User3Id",
                table: "MatchTeams",
                column: "User3Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_Users_User4Id",
                table: "MatchTeams",
                column: "User4Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_Users_User5Id",
                table: "MatchTeams",
                column: "User5Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
