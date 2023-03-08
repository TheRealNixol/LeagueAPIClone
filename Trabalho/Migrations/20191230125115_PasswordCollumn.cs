using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho.Migrations
{
    public partial class PasswordCollumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30) CHARACTER SET utf8mb4",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "varchar(30) CHARACTER SET utf8mb4",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);
        }
    }
}
