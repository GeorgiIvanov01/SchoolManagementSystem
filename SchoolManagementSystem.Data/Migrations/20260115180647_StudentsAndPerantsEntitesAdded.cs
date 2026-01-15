using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class StudentsAndPerantsEntitesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Teacher_TeacherId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTeacher_Subject_SubjectsId",
                table: "SubjectTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTeacher_Teacher_TeachersId",
                table: "SubjectTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectTeacher",
                table: "SubjectTeacher");

            migrationBuilder.RenameTable(
                name: "SubjectTeacher",
                newName: "TeacherSubjects");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectTeacher_TeachersId",
                table: "TeacherSubjects",
                newName: "IX_TeacherSubjects_TeachersId");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Teacher",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teacher",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teacher",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "PhoneNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Emails",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherSubjects",
                table: "TeacherSubjects",
                columns: new[] { "SubjectsId", "TeachersId" });

            migrationBuilder.CreateTable(
                name: "GradeBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GradeBook_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsParents",
                columns: table => new
                {
                    ParentsId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsParents", x => new { x.ParentsId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_StudentsParents_Parent_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsParents_Student_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_ParentId",
                table: "PhoneNumbers",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ParentId",
                table: "Emails",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeBook_StudentId",
                table: "GradeBook",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentsParents_StudentsId",
                table: "StudentsParents",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Parent_ParentId",
                table: "Emails",
                column: "ParentId",
                principalTable: "Parent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Teacher_TeacherId",
                table: "Emails",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Parent_ParentId",
                table: "PhoneNumbers",
                column: "ParentId",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSubjects_Subject_SubjectsId",
                table: "TeacherSubjects",
                column: "SubjectsId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSubjects_Teacher_TeachersId",
                table: "TeacherSubjects",
                column: "TeachersId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Parent_ParentId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Teacher_TeacherId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Parent_ParentId",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSubjects_Subject_SubjectsId",
                table: "TeacherSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSubjects_Teacher_TeachersId",
                table: "TeacherSubjects");

            migrationBuilder.DropTable(
                name: "GradeBook");

            migrationBuilder.DropTable(
                name: "StudentsParents");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_ParentId",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Emails_ParentId",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherSubjects",
                table: "TeacherSubjects");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Emails");

            migrationBuilder.RenameTable(
                name: "TeacherSubjects",
                newName: "SubjectTeacher");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherSubjects_TeachersId",
                table: "SubjectTeacher",
                newName: "IX_SubjectTeacher_TeachersId");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectTeacher",
                table: "SubjectTeacher",
                columns: new[] { "SubjectsId", "TeachersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Teacher_TeacherId",
                table: "Emails",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTeacher_Subject_SubjectsId",
                table: "SubjectTeacher",
                column: "SubjectsId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTeacher_Teacher_TeachersId",
                table: "SubjectTeacher",
                column: "TeachersId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
