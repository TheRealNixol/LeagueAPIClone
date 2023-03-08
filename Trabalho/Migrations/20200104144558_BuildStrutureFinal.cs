using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class BuildStrutureFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuild_Items_Slot1Id",
                table: "MatchBuild");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuild_Items_Slot2Id",
                table: "MatchBuild");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuild_Items_Slot3Id",
                table: "MatchBuild");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuild_Items_Slot4Id",
                table: "MatchBuild");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuild_Items_Slot5Id",
                table: "MatchBuild");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuild_Items_Slot6Id",
                table: "MatchBuild");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuild_Items_TrinketId",
                table: "MatchBuild");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_MatchBuild_BuildId",
                table: "MatchPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchBuild",
                table: "MatchBuild");

            migrationBuilder.RenameTable(
                name: "MatchBuild",
                newName: "MatcheBuilds");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuild_TrinketId",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_TrinketId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuild_Slot6Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot6Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuild_Slot5Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot5Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuild_Slot4Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot4Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuild_Slot3Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot3Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuild_Slot2Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot2Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuild_Slot1Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot1Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatcheBuilds",
                table: "MatcheBuilds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatcheBuilds_Items_Slot1Id",
                table: "MatcheBuilds",
                column: "Slot1Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatcheBuilds_Items_Slot2Id",
                table: "MatcheBuilds",
                column: "Slot2Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatcheBuilds_Items_Slot3Id",
                table: "MatcheBuilds",
                column: "Slot3Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatcheBuilds_Items_Slot4Id",
                table: "MatcheBuilds",
                column: "Slot4Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatcheBuilds_Items_Slot5Id",
                table: "MatcheBuilds",
                column: "Slot5Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatcheBuilds_Items_Slot6Id",
                table: "MatcheBuilds",
                column: "Slot6Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatcheBuilds_Items_TrinketId",
                table: "MatcheBuilds",
                column: "TrinketId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_MatcheBuilds_BuildId",
                table: "MatchPlayers",
                column: "BuildId",
                principalTable: "MatcheBuilds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatcheBuilds_Items_Slot1Id",
                table: "MatcheBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatcheBuilds_Items_Slot2Id",
                table: "MatcheBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatcheBuilds_Items_Slot3Id",
                table: "MatcheBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatcheBuilds_Items_Slot4Id",
                table: "MatcheBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatcheBuilds_Items_Slot5Id",
                table: "MatcheBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatcheBuilds_Items_Slot6Id",
                table: "MatcheBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatcheBuilds_Items_TrinketId",
                table: "MatcheBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_MatcheBuilds_BuildId",
                table: "MatchPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatcheBuilds",
                table: "MatcheBuilds");

            migrationBuilder.RenameTable(
                name: "MatcheBuilds",
                newName: "MatchBuild");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_TrinketId",
                table: "MatchBuild",
                newName: "IX_MatchBuild_TrinketId");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot6Id",
                table: "MatchBuild",
                newName: "IX_MatchBuild_Slot6Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot5Id",
                table: "MatchBuild",
                newName: "IX_MatchBuild_Slot5Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot4Id",
                table: "MatchBuild",
                newName: "IX_MatchBuild_Slot4Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot3Id",
                table: "MatchBuild",
                newName: "IX_MatchBuild_Slot3Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot2Id",
                table: "MatchBuild",
                newName: "IX_MatchBuild_Slot2Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot1Id",
                table: "MatchBuild",
                newName: "IX_MatchBuild_Slot1Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchBuild",
                table: "MatchBuild",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuild_Items_Slot1Id",
                table: "MatchBuild",
                column: "Slot1Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuild_Items_Slot2Id",
                table: "MatchBuild",
                column: "Slot2Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuild_Items_Slot3Id",
                table: "MatchBuild",
                column: "Slot3Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuild_Items_Slot4Id",
                table: "MatchBuild",
                column: "Slot4Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuild_Items_Slot5Id",
                table: "MatchBuild",
                column: "Slot5Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuild_Items_Slot6Id",
                table: "MatchBuild",
                column: "Slot6Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuild_Items_TrinketId",
                table: "MatchBuild",
                column: "TrinketId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_MatchBuild_BuildId",
                table: "MatchPlayers",
                column: "BuildId",
                principalTable: "MatchBuild",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
