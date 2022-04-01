using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalPark.Migrations
{
    public partial class SeedDataAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Name", "Notes", "Trails" },
                values: new object[] { 2, "The Land of Test", "Test", "Test this api is working", "Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Name", "Notes", "Trails" },
                values: new object[] { 1, "The Land of Test", "Test", "Test this api is working", "Test" });
        }
    }
}
