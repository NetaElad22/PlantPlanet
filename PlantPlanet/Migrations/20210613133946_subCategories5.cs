using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantPlanet.Migrations
{
    public partial class subCategories5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_SubCategory_SubCategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "ProductSubCategory",
                columns: table => new
                {
                    ProductsProductId = table.Column<int>(type: "int", nullable: false),
                    SubCategoriesSubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategory", x => new { x.ProductsProductId, x.SubCategoriesSubCategoryId });
                    table.ForeignKey(
                        name: "FK_ProductSubCategory_Product_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSubCategory_SubCategory_SubCategoriesSubCategoryId",
                        column: x => x.SubCategoriesSubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategory_SubCategoriesSubCategoryId",
                table: "ProductSubCategory",
                column: "SubCategoriesSubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSubCategory");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SubCategory_SubCategoryId",
                table: "Product",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "SubCategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
