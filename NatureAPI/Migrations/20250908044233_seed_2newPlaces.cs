using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class seed_2newPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 2, true, "Historical", new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historic pre-Hispanic pyramids near Mexico City, a must-see archaeological site.", 2300, 85.0, 19.692499999999999, -98.843800000000002, "Teotihuacan Pyramids", "09:00 - 17:00" },
                    { 3, true, "Nature", new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Famous rock formations that resemble waterfalls, with natural mineral pools in Oaxaca.", 1800, 50.0, 16.873200000000001, -96.450000000000003, "Hierve el Agua", "07:00 - 18:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
