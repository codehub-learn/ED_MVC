using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ED_MVC.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(8,0)",
                precision: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageLoc", "Name" },
                values: new object[,]
                {
                    { 1, "Premium Chocolate Bars, Chocolate Boxes and Pralines. Premium dark, milk and white chocolate. Gift boxes available.", "category_chocolates.jpg", "Chocolates and Pralines" },
                    { 2, "Cakes, Tarts and Pies. High quality premium chocolate based deserts available in a handpicked collection of various flavors and fillings.", "category_pies.jpg", "Pies" },
                    { 3, "Chocolate Ice Cream and Ice Creamsicles. High quality fresh ice cream based on our premium chocolate products.", "category_icecream.jpg", "Ice Cream" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageLoc", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "High Quality Milk Chocolate Bar 30% Cocoa 200g", "product_milkbar.jpg", "Milk Chocolate Bar", 4.35m },
                    { 2, 1, "Premium Cocoa Butter White Chocolate Bar 210g", "product_whitechocolate.jpg", "White Chocolate Bar", 5.20m },
                    { 3, 3, "6 60g Chocolate Ice Creamsicles with praline filling", "product_creamsicles.jpg", "Chocolate Ice Creamsicles", 5.20m },
                    { 4, 2, "Chocolate Cake with Raspberry Flavoring, 650g", "product_cake.jpg", "Chocolate and Raspberry Cake", 35.25m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,0)",
                oldPrecision: 8);
        }
    }
}
