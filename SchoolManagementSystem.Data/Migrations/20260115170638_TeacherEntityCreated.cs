using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class TeacherEntityCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDirector",
                table: "Teacher",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHeadTeacher",
                table: "Teacher",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "PhoneNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Emails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_TeacherId",
                table: "PhoneNumbers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_TeacherId",
                table: "Emails",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Teacher_TeacherId",
                table: "Emails",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Teacher_TeacherId",
                table: "PhoneNumbers",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Teacher_TeacherId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Teacher_TeacherId",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_TeacherId",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Emails_TeacherId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "IsDirector",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "IsHeadTeacher",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Emails");
        }
    }
}
