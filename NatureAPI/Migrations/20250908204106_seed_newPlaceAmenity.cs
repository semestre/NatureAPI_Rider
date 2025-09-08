using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class seed_newPlaceAmenity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceAmenity",
                columns: new[] { "AmenityId", "PlaceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 4, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 4, 3 },
                    { 5, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 5, 3 });
        }
    }
}
