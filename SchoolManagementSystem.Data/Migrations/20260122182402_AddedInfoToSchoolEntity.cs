using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedInfoToSchoolEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info_Address",
                table: "Schools",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Schools_Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Emails_Schools_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schools_PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_PhoneNumbers_Schools_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schools_Emails_OwnerId",
                table: "Schools_Emails",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_PhoneNumbers_OwnerId",
                table: "Schools_PhoneNumbers",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools_Emails");

            migrationBuilder.DropTable(
                name: "Schools_PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "Info_Address",
                table: "Schools");
        }
    }
}
