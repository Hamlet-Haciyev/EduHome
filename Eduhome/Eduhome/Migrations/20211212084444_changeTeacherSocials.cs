using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class changeTeacherSocials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherToSocials_Socials_SocialId",
                table: "TeacherToSocials");

            migrationBuilder.DropIndex(
                name: "IX_TeacherToSocials_SocialId",
                table: "TeacherToSocials");

            migrationBuilder.DropColumn(
                name: "SocialId",
                table: "TeacherToSocials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocialId",
                table: "TeacherToSocials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherToSocials_SocialId",
                table: "TeacherToSocials",
                column: "SocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherToSocials_Socials_SocialId",
                table: "TeacherToSocials",
                column: "SocialId",
                principalTable: "Socials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
