using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class changeTeacherSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percent",
                table: "Skills");

            migrationBuilder.AddColumn<byte>(
                name: "Percent",
                table: "Teacher_Skills",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percent",
                table: "Teacher_Skills");

            migrationBuilder.AddColumn<byte>(
                name: "Percent",
                table: "Skills",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
