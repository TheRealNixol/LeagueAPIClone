using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class BuildStrutureFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Build",
                table: "MatchPlayers");

            migrationBuilder.AddColumn<int>(
                name: "BuildId",
                table: "MatchPlayers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MatchBuild",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Slot1Id = table.Column<int>(nullable: true),
                    Slot2Id = table.Column<int>(nullable: true),
                    Slot3Id = table.Column<int>(nullable: true),
                    Slot4Id = table.Column<int>(nullable: true),
                    Slot5Id = table.Column<int>(nullable: true),
                    Slot6Id = table.Column<int>(nullable: true),
                    TrinketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchBuild", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchBuild_Items_Slot1Id",
                        column: x => x.Slot1Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchBuild_Items_Slot2Id",
                        column: x => x.Slot2Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchBuild_Items_Slot3Id",
                        column: x => x.Slot3Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchBuild_Items_Slot4Id",
                        column: x => x.Slot4Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchBuild_Items_Slot5Id",
                        column: x => x.Slot5Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchBuild_Items_Slot6Id",
                        column: x => x.Slot6Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchBuild_Items_TrinketId",
                        column: x => x.TrinketId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayers_BuildId",
                table: "MatchPlayers",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchBuild_Slot1Id",
                table: "MatchBuild",
                column: "Slot1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchBuild_Slot2Id",
                table: "MatchBuild",
                column: "Slot2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchBuild_Slot3Id",
                table: "MatchBuild",
                column: "Slot3Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchBuild_Slot4Id",
                table: "MatchBuild",
                column: "Slot4Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchBuild_Slot5Id",
                table: "MatchBuild",
                column: "Slot5Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchBuild_Slot6Id",
                table: "MatchBuild",
                column: "Slot6Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchBuild_TrinketId",
                table: "MatchBuild",
                column: "TrinketId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_MatchBuild_BuildId",
                table: "MatchPlayers",
                column: "BuildId",
                principalTable: "MatchBuild",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_MatchBuild_BuildId",
                table: "MatchPlayers");

            migrationBuilder.DropTable(
                name: "MatchBuild");

            migrationBuilder.DropIndex(
                name: "IX_MatchPlayers_BuildId",
                table: "MatchPlayers");

            migrationBuilder.DropColumn(
                name: "BuildId",
                table: "MatchPlayers");

            migrationBuilder.AddColumn<string>(
                name: "Build",
                table: "MatchPlayers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
