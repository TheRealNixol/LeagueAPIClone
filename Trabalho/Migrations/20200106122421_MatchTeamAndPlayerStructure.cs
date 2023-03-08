using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class MatchTeamAndPlayerStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_Matches_GameId",
                table: "MatchPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_MatchTeams_TeamId",
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

            migrationBuilder.DropIndex(
                name: "IX_MatchPlayers_GameId",
                table: "MatchPlayers");

            migrationBuilder.DropIndex(
                name: "IX_MatchPlayers_TeamId",
                table: "MatchPlayers");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "MatchPlayers");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "MatchPlayers");

            migrationBuilder.AlterColumn<int>(
                name: "User5Id",
                table: "MatchTeams",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User4Id",
                table: "MatchTeams",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User3Id",
                table: "MatchTeams",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User2Id",
                table: "MatchTeams",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User1Id",
                table: "MatchTeams",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User1Id",
                table: "MatchTeams",
                column: "User1Id",
                principalTable: "MatchPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User2Id",
                table: "MatchTeams",
                column: "User2Id",
                principalTable: "MatchPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User3Id",
                table: "MatchTeams",
                column: "User3Id",
                principalTable: "MatchPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User4Id",
                table: "MatchTeams",
                column: "User4Id",
                principalTable: "MatchPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User5Id",
                table: "MatchTeams",
                column: "User5Id",
                principalTable: "MatchPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User1Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User2Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User3Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User4Id",
                table: "MatchTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchTeams_MatchPlayers_User5Id",
                table: "MatchTeams");

            migrationBuilder.AlterColumn<long>(
                name: "User5Id",
                table: "MatchTeams",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "User4Id",
                table: "MatchTeams",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "User3Id",
                table: "MatchTeams",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "User2Id",
                table: "MatchTeams",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "User1Id",
                table: "MatchTeams",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "MatchPlayers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "MatchPlayers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayers_GameId",
                table: "MatchPlayers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayers_TeamId",
                table: "MatchPlayers",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_Matches_GameId",
                table: "MatchPlayers",
                column: "GameId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_MatchTeams_TeamId",
                table: "MatchPlayers",
                column: "TeamId",
                principalTable: "MatchTeams",
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
    }
}
