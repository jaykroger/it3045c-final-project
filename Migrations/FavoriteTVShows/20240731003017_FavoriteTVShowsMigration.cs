using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045C_Final_Project.Migrations.FavoriteTVShows
{
    /// <inheritdoc />
    public partial class FavoriteTVShowsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteTVShows",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumSeasons = table.Column<int>(type: "int", nullable: true),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteTVShows", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "FavoriteTVShows",
                columns: new[] { "StudentID", "Genre", "NumSeasons", "ReleaseDate", "ShowName" },
                values: new object[,]
                {
                    { 14981719, "Drama", 4, new DateOnly(2018, 6, 3), "Succession" },
                    { 14981720, "Crime", 4, new DateOnly(2015, 6, 24), "Mr. Robot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteTVShows");
        }
    }
}
