using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPI.Migrations
{
    /// <inheritdoc />
    public partial class _2PhotosForEachPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "PlaceId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://rivieramaya.mx/fotos/2020/11/cenote-azul-tulum.jpg" },
                    { 2, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQG1YpDTVj2MYA94FYZETCnZa8yxQ_AXyZxBA&s" },
                    { 3, 2, "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcTCAIwPvRenbX3NFdS_xlKhrvMBSVwYAp52-PQvZxjkB6uRww6uoLtL99Lc52PRxvt3hnEu29lcIP_PjCFu5zWBMK-pcmsutvBm2-NTDw" },
                    { 4, 2, "https://lh3.googleusercontent.com/gps-cs-s/AC9h4nqaEJgVpFFh6K9n69psf0kbOmizOGaZt0t4AxxCkOGfpnwmTecctwPdwOniRWUvdDx5aAELs1cyJpOGiyrTTJUYwTWP5ise_nVlLV3sMnGoG4wJzby7MI2-mZJu6oIY6UNbpvEy8w=w1080-h624-n-k-no" },
                    { 5, 3, "https://lh3.googleusercontent.com/gps-cs-s/AC9h4npPG6jc703Ex8VKyyehRbShbUyGxv17nadJNJ46DPZMtagDFKl2h3Mg_co6_fVn70WnI00afnBFKNRGkdh213L5DCj-sC5xYz75fWx3awET6jTcyBRi9b7Pscv3hZagrvUgOs5M=w135-h156-n-k-no" },
                    { 6, 3, "https://img.freepik.com/premium-vector/boiling-water-red-pot-cooking-pan-stove-with-water-steam-vector-illustration_163786-921.jpg?semt=ais_hybrid&w=740&q=80" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
