using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045C_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class CourseEnrollmentsInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseEnrollments",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Track = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditHours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseEnrollments", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "CourseEnrollments",
                columns: new[] { "StudentID", "CourseName", "CourseNumber", "CreditHours", "Track" },
                values: new object[,]
                {
                    { 14981719, "Contemporary Programming", "IT3045C", 3, "Software Application Development" },
                    { 14981720, "Network Security", "IT3071C", 3, "Cybersecurity" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseEnrollments");
        }
    }
}
