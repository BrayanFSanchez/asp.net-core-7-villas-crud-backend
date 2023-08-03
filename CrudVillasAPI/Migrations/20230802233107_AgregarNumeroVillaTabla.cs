using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudVillasAPI.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNumeroVillaTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "creationDate", "updateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9227), new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "creationDate", "updateDate" },
                values: new object[] { new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9244), new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "creationDate", "updateDate" },
                values: new object[] { new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "creationDate", "updateDate" },
                values: new object[] { new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6484), new DateTime(2023, 7, 28, 18, 51, 6, 364, DateTimeKind.Local).AddTicks(6484) });
        }
    }
}
