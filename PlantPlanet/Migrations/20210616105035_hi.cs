using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantPlanet.Migrations
{
    public partial class hi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(name: "User", columns: table => new { });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
