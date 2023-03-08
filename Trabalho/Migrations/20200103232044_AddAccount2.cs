using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class AddAccount2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngameAccount_UsersQuickStat_QuickStatId",
                table: "IngameAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_IngameAccount_AccountId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UsersQuickStat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngameAccount",
                table: "IngameAccount");

            migrationBuilder.RenameTable(
                name: "IngameAccount",
                newName: "IngameAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_IngameAccount_QuickStatId",
                table: "IngameAccounts",
                newName: "IX_IngameAccounts_QuickStatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngameAccounts",
                table: "IngameAccounts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IngameAccountQuickStats",
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
                    table.PrimaryKey("PK_IngameAccountQuickStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngameAccountQuickStats_Champions_MainChampId",
                        column: x => x.MainChampId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngameAccountQuickStats_MainChampId",
                table: "IngameAccountQuickStats",
                column: "MainChampId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngameAccounts_IngameAccountQuickStats_QuickStatId",
                table: "IngameAccounts",
                column: "QuickStatId",
                principalTable: "IngameAccountQuickStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_IngameAccounts_AccountId",
                table: "Users",
                column: "AccountId",
                principalTable: "IngameAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngameAccounts_IngameAccountQuickStats_QuickStatId",
                table: "IngameAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_IngameAccounts_AccountId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "IngameAccountQuickStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngameAccounts",
                table: "IngameAccounts");

            migrationBuilder.RenameTable(
                name: "IngameAccounts",
                newName: "IngameAccount");

            migrationBuilder.RenameIndex(
                name: "IX_IngameAccounts_QuickStatId",
                table: "IngameAccount",
                newName: "IX_IngameAccount_QuickStatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngameAccount",
                table: "IngameAccount",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UsersQuickStat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HighestWinRateChamp = table.Column<int>(type: "int", nullable: false),
                    MainChampId = table.Column<int>(type: "int", nullable: false),
                    RankFlex = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RankSolo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_UsersQuickStat_MainChampId",
                table: "UsersQuickStat",
                column: "MainChampId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngameAccount_UsersQuickStat_QuickStatId",
                table: "IngameAccount",
                column: "QuickStatId",
                principalTable: "UsersQuickStat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_IngameAccount_AccountId",
                table: "Users",
                column: "AccountId",
                principalTable: "IngameAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
