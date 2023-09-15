using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedBadgeFinal.Data.Migrations
{
    /// <inheritdoc />
    public partial class Changedweaponnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Sword");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Claymore");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Polearm");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "Bow");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Swords");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Claymores");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Polearms");

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "Bows");
        }
    }
}
