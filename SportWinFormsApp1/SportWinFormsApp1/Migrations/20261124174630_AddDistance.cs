using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportWinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddDistance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "distanceKm",
                table: "Workouts",
                newName: "Distance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Distance",
                table: "Workouts",
                newName: "distanceKm");
        }
    }
}
