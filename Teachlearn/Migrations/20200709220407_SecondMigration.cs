using Microsoft.EntityFrameworkCore.Migrations;

namespace Teachlearn.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassroomMessage",
                table: "Classrooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignmentPresence",
                table: "Assignments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassroomMessage",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "AssignmentPresence",
                table: "Assignments");
        }
    }
}
