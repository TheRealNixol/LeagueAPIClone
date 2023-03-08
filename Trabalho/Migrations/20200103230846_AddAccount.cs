using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class AddAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UsersQuickStat_QuickStatId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_QuickStatId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "QuickStatId",
                table: "Users");

            migrationBuilder.AddColumn<long>(
                name: "AccountId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IngameAccount",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    QuickStatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngameAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngameAccount_UsersQuickStat_QuickStatId",
                        column: x => x.QuickStatId,
                        principalTable: "UsersQuickStat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountId",
                table: "Users",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_IngameAccount_QuickStatId",
                table: "IngameAccount",
                column: "QuickStatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_IngameAccount_AccountId",
                table: "Users",
                column: "AccountId",
                principalTable: "IngameAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_IngameAccount_AccountId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "IngameAccount");

            migrationBuilder.DropIndex(
                name: "IX_Users_AccountId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuickStatId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
