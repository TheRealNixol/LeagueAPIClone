using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChampionsAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Passive = table.Column<string>(nullable: true),
                    Q = table.Column<string>(nullable: true),
                    W = table.Column<string>(nullable: true),
                    E = table.Column<string>(nullable: true),
                    R = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionsAbilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AbilitiesId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Lore = table.Column<string>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_ChampionsAbilities_AbilitiesId",
                        column: x => x.AbilitiesId,
                        principalTable: "ChampionsAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchTeams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User1Id = table.Column<long>(nullable: true),
                    User2Id = table.Column<long>(nullable: true),
                    User3Id = table.Column<long>(nullable: true),
                    User4Id = table.Column<long>(nullable: true),
                    User5Id = table.Column<long>(nullable: true),
                    TotalGold = table.Column<int>(nullable: false),
                    Objectives = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchTeams_Users_User1Id",
                        column: x => x.User1Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchTeams_Users_User2Id",
                        column: x => x.User2Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchTeams_Users_User3Id",
                        column: x => x.User3Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchTeams_Users_User4Id",
                        column: x => x.User4Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchTeams_Users_User5Id",
                        column: x => x.User5Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersQuickStat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MainChampId = table.Column<int>(nullable: false),
                    HighestWinRateChamp = table.Column<int>(nullable: false),
                    RankSolo = table.Column<string>(nullable: true),
                    RankFlex = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersQuickStat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersQuickStat_Champions_MainChampId",
                        column: x => x.MainChampId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TeamBlueId = table.Column<int>(nullable: false),
                    TeamRedId = table.Column<int>(nullable: false),
                    GameType = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    WinnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_MatchTeams_TeamBlueId",
                        column: x => x.TeamBlueId,
                        principalTable: "MatchTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_MatchTeams_TeamRedId",
                        column: x => x.TeamRedId,
                        principalTable: "MatchTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_MatchTeams_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "MatchTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    ChampionId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Gold = table.Column<int>(nullable: false),
                    Kills = table.Column<int>(nullable: false),
                    Deaths = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false),
                    Kda = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchPlayers_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchPlayers_Matches_GameId",
                        column: x => x.GameId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchPlayers_MatchTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "MatchTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchPlayers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Icon = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Gold = table.Column<int>(nullable: false),
                    MatchPlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_MatchPlayers_MatchPlayerId",
                        column: x => x.MatchPlayerId,
                        principalTable: "MatchPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champions_AbilitiesId",
                table: "Champions",
                column: "AbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MatchPlayerId",
                table: "Items",
                column: "MatchPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamBlueId",
                table: "Matches",
                column: "TeamBlueId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamRedId",
                table: "Matches",
                column: "TeamRedId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerId",
                table: "Matches",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayers_ChampionId",
                table: "MatchPlayers",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayers_GameId",
                table: "MatchPlayers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayers_TeamId",
                table: "MatchPlayers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayers_UserId",
                table: "MatchPlayers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeams_User1Id",
                table: "MatchTeams",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeams_User2Id",
                table: "MatchTeams",
                column: "User2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeams_User3Id",
                table: "MatchTeams",
                column: "User3Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeams_User4Id",
                table: "MatchTeams",
                column: "User4Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeams_User5Id",
                table: "MatchTeams",
                column: "User5Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsersQuickStat_MainChampId",
                table: "UsersQuickStat",
                column: "MainChampId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "UsersQuickStat");

            migrationBuilder.DropTable(
                name: "MatchPlayers");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "ChampionsAbilities");

            migrationBuilder.DropTable(
                name: "MatchTeams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
