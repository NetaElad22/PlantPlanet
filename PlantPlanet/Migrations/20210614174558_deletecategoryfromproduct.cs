using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantPlanet.Migrations
{
    public partial class deletecategoryfromproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Product_Category_CategoryId",
            //    table: "Product");

            //migrationBuilder.DropIndex(
            //    name: "IX_Product_CategoryId",
            //    table: "Product");

            //migrationBuilder.DropColumn(
            //    name: "CategoryId",
            //    table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.AddColumn<int>(
            //        name: "CategoryId",
            //        table: "Product",
            //        type: "int",
            //        nullable: true);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Product_CategoryId",
            //        table: "Product",
            //        column: "CategoryId");

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_Product_Category_CategoryId",
            //        table: "Product",
            //        column: "CategoryId",
            //        principalTable: "Category",
            //        principalColumn: "CategoryId",
            //        onDelete: ReferentialAction.Restrict);
        }
    }
}
