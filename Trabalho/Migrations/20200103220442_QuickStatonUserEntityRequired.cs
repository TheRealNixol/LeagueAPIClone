using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class QuickStatonUserEntityRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UsersQuickStat_QuickStatId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "QuickStatId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UsersQuickStat_QuickStatId",
                table: "Users",
                column: "QuickStatId",
                principalTable: "UsersQuickStat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UsersQuickStat_QuickStatId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "QuickStatId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UsersQuickStat_QuickStatId",
                table: "Users",
                column: "QuickStatId",
                principalTable: "UsersQuickStat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
