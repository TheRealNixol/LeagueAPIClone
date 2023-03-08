using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class QuickStatonUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50) CHARACTER SET utf8mb4",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "QuickStatId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_QuickStatId",
                table: "Users",
                column: "QuickStatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UsersQuickStat_QuickStatId",
                table: "Users",
                column: "QuickStatId",
                principalTable: "UsersQuickStat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UsersQuickStat_QuickStatId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_QuickStatId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "QuickStatId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
