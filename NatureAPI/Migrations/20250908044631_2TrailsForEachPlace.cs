using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class _2TrailsForEachPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "Id", "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[,]
                {
                    { 1, "Easy", 2.5, 60, true, "Cenote Azul Loop", "encoded_path_1", 1 },
                    { 2, "Moderate", 3.2000000000000002, 90, false, "Riverside Trail", "encoded_path_2", 1 },
                    { 3, "Easy", 1.5, 45, true, "Pyramid Base Walk", "encoded_path_3", 2 },
                    { 4, "Moderate", 2.7999999999999998, 70, false, "Avenue of the Dead Walk", "encoded_path_4", 2 },
                    { 5, "Moderate", 1.8, 50, true, "Upper Falls Trail", "encoded_path_5", 3 },
                    { 6, "Easy", 2.2999999999999998, 65, false, "Mineral Pools Trail", "encoded_path_6", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
