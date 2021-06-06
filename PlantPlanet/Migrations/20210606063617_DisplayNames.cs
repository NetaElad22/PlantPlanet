using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantPlanet.Migrations
{
    public partial class DisplayNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Supplier",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ExtraInfo",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "ExtraInfo",
                table: "Address");
        }
    }
}
