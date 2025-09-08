using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class seed_newPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { "Nature", new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A beautiful natural swimming hole with crystal-clear water in the heart of Quintana Roo.", 5, 100.0, 20.582100000000001, -87.121499999999997, "Cenote Azul", "08:00 - 17:00" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { "Waterfall", new DateTime(2025, 9, 8, 4, 17, 55, 172, DateTimeKind.Utc).AddTicks(6099), "One of the most spectacular waterfalls in San Luis Potosí, with turquoise waters surrounded by jungle.", 300, 50.0, 21.750699999999998, -99.154200000000003, "Cascada de Tamul", "08:00-18:00" });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 2, true, "Park", new DateTime(2025, 9, 8, 4, 17, 55, 172, DateTimeKind.Utc).AddTicks(7060), "A stratovolcano with twin crater lakes, popular for hiking and mountaineering.", 4680, 54.0, 19.1083, -99.757400000000004, "Parque Nacional Nevado de Toluca", "07:00-17:00" },
                    { 3, true, "Viewpoint", new DateTime(2025, 9, 8, 4, 17, 55, 172, DateTimeKind.Utc).AddTicks(7071), "A dramatic canyon with cliffs over 1,000 meters high, navigable by boat on the Grijalva River.", 500, 40.0, 16.8734, -93.070400000000006, "Sumidero Canyon", "09:00-17:00" },
                    { 4, true, "Park", new DateTime(2025, 9, 8, 4, 17, 55, 172, DateTimeKind.Utc).AddTicks(7082), "Rock formations that resemble frozen waterfalls, with natural mineral springs and pools.", 1800, 25.0, 16.867000000000001, -96.266099999999994, "Hierve el Agua", "08:00-18:00" },
                    { 5, false, "Viewpoint", new DateTime(2025, 9, 8, 4, 17, 55, 172, DateTimeKind.Utc).AddTicks(7092), "A massive open-air cave and one of the world’s deepest pits, home to thousands of swifts and parakeets.", 750, 30.0, 21.5991, -99.098600000000005, "Sótano de las Golondrinas", "06:00-17:00" }
                });
        }
    }
}
