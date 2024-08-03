using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045C_Final_Project.Migrations.TVShows
{
    /// <inheritdoc />
    public partial class TVShowsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TVShows",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumSeasons = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShows", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "TVShows",
                columns: new[] { "ID", "Genre", "NumSeasons", "ReleaseDate", "ShowName" },
                values: new object[,]
                {
                    { 1, "Drama", 4, new DateOnly(2018, 6, 3), "Succession" },
                    { 2, "Crime", 4, new DateOnly(2015, 6, 24), "Mr. Robot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TVShows");
        }
    }
}
