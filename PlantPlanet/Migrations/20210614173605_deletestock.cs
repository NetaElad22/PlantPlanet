using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantPlanet.Migrations
{
    public partial class deletestock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Stock_AvailableStockStockId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Product_AvailableStockStockId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "AvailableStockStockId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "Product",
                newName: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Product",
                newName: "StockId");

            migrationBuilder.AddColumn<int>(
                name: "AvailableStockStockId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastUpdatedQuantity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_AvailableStockStockId",
                table: "Product",
                column: "AvailableStockStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Stock_AvailableStockStockId",
                table: "Product",
                column: "AvailableStockStockId",
                principalTable: "Stock",
                principalColumn: "StockId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
