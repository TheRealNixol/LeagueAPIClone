using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class BuildStrutureFinalMispell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "MatchBuilds");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_TrinketId",
                table: "MatchBuilds",
                newName: "IX_MatchBuilds_TrinketId");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot6Id",
                table: "MatchBuilds",
                newName: "IX_MatchBuilds_Slot6Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot5Id",
                table: "MatchBuilds",
                newName: "IX_MatchBuilds_Slot5Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot4Id",
                table: "MatchBuilds",
                newName: "IX_MatchBuilds_Slot4Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot3Id",
                table: "MatchBuilds",
                newName: "IX_MatchBuilds_Slot3Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot2Id",
                table: "MatchBuilds",
                newName: "IX_MatchBuilds_Slot2Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatcheBuilds_Slot1Id",
                table: "MatchBuilds",
                newName: "IX_MatchBuilds_Slot1Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchBuilds",
                table: "MatchBuilds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuilds_Items_Slot1Id",
                table: "MatchBuilds",
                column: "Slot1Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuilds_Items_Slot2Id",
                table: "MatchBuilds",
                column: "Slot2Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuilds_Items_Slot3Id",
                table: "MatchBuilds",
                column: "Slot3Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuilds_Items_Slot4Id",
                table: "MatchBuilds",
                column: "Slot4Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuilds_Items_Slot5Id",
                table: "MatchBuilds",
                column: "Slot5Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuilds_Items_Slot6Id",
                table: "MatchBuilds",
                column: "Slot6Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchBuilds_Items_TrinketId",
                table: "MatchBuilds",
                column: "TrinketId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_MatchBuilds_BuildId",
                table: "MatchPlayers",
                column: "BuildId",
                principalTable: "MatchBuilds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuilds_Items_Slot1Id",
                table: "MatchBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuilds_Items_Slot2Id",
                table: "MatchBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuilds_Items_Slot3Id",
                table: "MatchBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuilds_Items_Slot4Id",
                table: "MatchBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuilds_Items_Slot5Id",
                table: "MatchBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuilds_Items_Slot6Id",
                table: "MatchBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchBuilds_Items_TrinketId",
                table: "MatchBuilds");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_MatchBuilds_BuildId",
                table: "MatchPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchBuilds",
                table: "MatchBuilds");

            migrationBuilder.RenameTable(
                name: "MatchBuilds",
                newName: "MatcheBuilds");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuilds_TrinketId",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_TrinketId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuilds_Slot6Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot6Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuilds_Slot5Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot5Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuilds_Slot4Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot4Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuilds_Slot3Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot3Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuilds_Slot2Id",
                table: "MatcheBuilds",
                newName: "IX_MatcheBuilds_Slot2Id");

            migrationBuilder.RenameIndex(
                name: "IX_MatchBuilds_Slot1Id",
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
    }
}
