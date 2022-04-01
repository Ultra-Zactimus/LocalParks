using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalPark.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Trails = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Notes = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Name", "Notes", "Trails" },
                values: new object[,]
                {
                    { 1, "The Land of Test", "Test 1", "Test this api is working", "Test" },
                    { 2, "The Land of Test", "Test 2", "Test this api is working", "Test" },
                    { 3, "The Land of Test", "Test 3", "Test this api is working", "Test" },
                    { 4, "The Land of Test", "Test 4", "Test this api is working", "Test" },
                    { 5, "The Land of Test", "Test 5", "Test this api is working", "Test" },
                    { 6, "The Land of Test", "Test 6", "Test this api is working", "Test" },
                    { 7, "The Land of Test", "Test 7", "Test this api is working", "Test" },
                    { 8, "The Land of Test", "Test 8", "Test this api is working", "Test" },
                    { 9, "The Land of Test", "Test 9", "Test this api is working", "Test" },
                    { 10, "The Land of Test", "Test 10", "Test this api is working", "Test" },
                    { 11, "The Land of Test", "Test 11", "Test this api is working", "Test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
