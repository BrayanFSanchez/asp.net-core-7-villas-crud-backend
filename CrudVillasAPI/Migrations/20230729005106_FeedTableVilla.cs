using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudVillasAPI.Migrations
{
    /// <inheritdoc />
    public partial class FeedTableVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "Detail", "Fee", "ImageUrl", "Name", "Occupants", "SquareMeter", "creationDate", "updateDate" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", 200.0, "", "Villa Real", 5, 50, new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6481) },
                    { 2, "", "Detalle de la Villa", 150.0, "", "Villa elegante", 4, 40, new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6484), new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6484) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
