using Microsoft.EntityFrameworkCore.Migrations;

namespace Teachlearn.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentPresence",
                table: "Assignments");

            migrationBuilder.AddColumn<string>(
                name: "CourseAttendance",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseAttendance",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "AssignmentPresence",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
