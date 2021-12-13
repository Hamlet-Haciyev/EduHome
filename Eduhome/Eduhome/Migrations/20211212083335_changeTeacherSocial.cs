using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class changeTeacherSocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherToSocials_Socials_Social_Id",
                table: "TeacherToSocials");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherToSocials_Teacher_Socials_Teacher_SocialId",
                table: "TeacherToSocials");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Teacher_Socials");

            migrationBuilder.RenameColumn(
                name: "Teacher_SocialId",
                table: "TeacherToSocials",
                newName: "SocialId");

            migrationBuilder.RenameColumn(
                name: "Social_Id",
                table: "TeacherToSocials",
                newName: "Teacher_Social_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherToSocials_Teacher_SocialId",
                table: "TeacherToSocials",
                newName: "IX_TeacherToSocials_SocialId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherToSocials_Social_Id",
                table: "TeacherToSocials",
                newName: "IX_TeacherToSocials_Teacher_Social_Id");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "TeacherToSocials",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherToSocials_Socials_SocialId",
                table: "TeacherToSocials",
                column: "SocialId",
                principalTable: "Socials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherToSocials_Teacher_Socials_Teacher_Social_Id",
                table: "TeacherToSocials",
                column: "Teacher_Social_Id",
                principalTable: "Teacher_Socials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherToSocials_Socials_SocialId",
                table: "TeacherToSocials");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherToSocials_Teacher_Socials_Teacher_Social_Id",
                table: "TeacherToSocials");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "TeacherToSocials");

            migrationBuilder.RenameColumn(
                name: "Teacher_Social_Id",
                table: "TeacherToSocials",
                newName: "Social_Id");

            migrationBuilder.RenameColumn(
                name: "SocialId",
                table: "TeacherToSocials",
                newName: "Teacher_SocialId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherToSocials_Teacher_Social_Id",
                table: "TeacherToSocials",
                newName: "IX_TeacherToSocials_Social_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherToSocials_SocialId",
                table: "TeacherToSocials",
                newName: "IX_TeacherToSocials_Teacher_SocialId");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Teacher_Socials",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherToSocials_Socials_Social_Id",
                table: "TeacherToSocials",
                column: "Social_Id",
                principalTable: "Socials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherToSocials_Teacher_Socials_Teacher_SocialId",
                table: "TeacherToSocials",
                column: "Teacher_SocialId",
                principalTable: "Teacher_Socials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
