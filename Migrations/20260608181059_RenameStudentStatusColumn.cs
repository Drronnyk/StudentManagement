using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class RenameStudentStatusColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentStatus",
                table: "Students",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Students",
                newName: "StudentStatus");
        }
    }
}
