using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.PersistenceDatabase.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Product 1", "Product 1", 561m },
                    { 73, "Product 73", "Product 73", 402m },
                    { 72, "Product 72", "Product 72", 960m },
                    { 71, "Product 71", "Product 71", 355m },
                    { 70, "Product 70", "Product 70", 918m },
                    { 69, "Product 69", "Product 69", 651m },
                    { 68, "Product 68", "Product 68", 451m },
                    { 67, "Product 67", "Product 67", 948m },
                    { 66, "Product 66", "Product 66", 104m },
                    { 65, "Product 65", "Product 65", 905m },
                    { 64, "Product 64", "Product 64", 153m },
                    { 63, "Product 63", "Product 63", 439m },
                    { 62, "Product 62", "Product 62", 356m },
                    { 61, "Product 61", "Product 61", 830m },
                    { 60, "Product 60", "Product 60", 165m },
                    { 59, "Product 59", "Product 59", 403m },
                    { 58, "Product 58", "Product 58", 134m },
                    { 57, "Product 57", "Product 57", 875m },
                    { 56, "Product 56", "Product 56", 273m },
                    { 55, "Product 55", "Product 55", 513m },
                    { 54, "Product 54", "Product 54", 767m },
                    { 53, "Product 53", "Product 53", 330m },
                    { 74, "Product 74", "Product 74", 446m },
                    { 52, "Product 52", "Product 52", 857m },
                    { 75, "Product 75", "Product 75", 913m },
                    { 77, "Product 77", "Product 77", 738m },
                    { 98, "Product 98", "Product 98", 595m },
                    { 97, "Product 97", "Product 97", 889m },
                    { 96, "Product 96", "Product 96", 971m },
                    { 95, "Product 95", "Product 95", 512m },
                    { 94, "Product 94", "Product 94", 188m },
                    { 93, "Product 93", "Product 93", 385m },
                    { 92, "Product 92", "Product 92", 388m },
                    { 91, "Product 91", "Product 91", 584m },
                    { 90, "Product 90", "Product 90", 473m },
                    { 89, "Product 89", "Product 89", 610m },
                    { 88, "Product 88", "Product 88", 640m },
                    { 87, "Product 87", "Product 87", 354m },
                    { 86, "Product 86", "Product 86", 598m },
                    { 85, "Product 85", "Product 85", 155m },
                    { 84, "Product 84", "Product 84", 842m },
                    { 83, "Product 83", "Product 83", 429m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Product 82", "Product 82", 642m },
                    { 81, "Product 81", "Product 81", 439m },
                    { 80, "Product 80", "Product 80", 758m },
                    { 79, "Product 79", "Product 79", 368m },
                    { 78, "Product 78", "Product 78", 997m },
                    { 76, "Product 76", "Product 76", 269m },
                    { 51, "Product 51", "Product 51", 976m },
                    { 50, "Product 50", "Product 50", 219m },
                    { 49, "Product 49", "Product 49", 909m },
                    { 22, "Product 22", "Product 22", 387m },
                    { 21, "Product 21", "Product 21", 498m },
                    { 20, "Product 20", "Product 20", 240m },
                    { 19, "Product 19", "Product 19", 689m },
                    { 18, "Product 18", "Product 18", 556m },
                    { 17, "Product 17", "Product 17", 649m },
                    { 16, "Product 16", "Product 16", 678m },
                    { 15, "Product 15", "Product 15", 377m },
                    { 14, "Product 14", "Product 14", 299m },
                    { 13, "Product 13", "Product 13", 476m },
                    { 12, "Product 12", "Product 12", 356m },
                    { 11, "Product 11", "Product 11", 589m },
                    { 10, "Product 10", "Product 10", 362m },
                    { 9, "Product 9", "Product 9", 185m },
                    { 8, "Product 8", "Product 8", 402m },
                    { 7, "Product 7", "Product 7", 595m },
                    { 6, "Product 6", "Product 6", 598m },
                    { 5, "Product 5", "Product 5", 397m },
                    { 4, "Product 4", "Product 4", 486m },
                    { 3, "Product 3", "Product 3", 212m },
                    { 2, "Product 2", "Product 2", 737m },
                    { 23, "Product 23", "Product 23", 862m },
                    { 24, "Product 24", "Product 24", 178m },
                    { 25, "Product 25", "Product 25", 182m },
                    { 26, "Product 26", "Product 26", 331m },
                    { 48, "Product 48", "Product 48", 225m },
                    { 47, "Product 47", "Product 47", 891m },
                    { 46, "Product 46", "Product 46", 423m },
                    { 45, "Product 45", "Product 45", 809m },
                    { 44, "Product 44", "Product 44", 864m },
                    { 43, "Product 43", "Product 43", 649m },
                    { 42, "Product 42", "Product 42", 329m },
                    { 41, "Product 41", "Product 41", 327m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Product 40", "Product 40", 343m },
                    { 39, "Product 39", "Product 39", 254m },
                    { 99, "Product 99", "Product 99", 959m },
                    { 38, "Product 38", "Product 38", 688m },
                    { 36, "Product 36", "Product 36", 459m },
                    { 35, "Product 35", "Product 35", 647m },
                    { 34, "Product 34", "Product 34", 124m },
                    { 33, "Product 33", "Product 33", 407m },
                    { 32, "Product 32", "Product 32", 584m },
                    { 31, "Product 31", "Product 31", 456m },
                    { 30, "Product 30", "Product 30", 131m },
                    { 29, "Product 29", "Product 29", 962m },
                    { 28, "Product 28", "Product 28", 339m },
                    { 27, "Product 27", "Product 27", 768m },
                    { 37, "Product 37", "Product 37", 423m },
                    { 100, "Product 100", "Product 100", 804m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 73, 73, 14 },
                    { 72, 72, 14 },
                    { 71, 71, 2 },
                    { 70, 70, 5 },
                    { 69, 69, 13 },
                    { 68, 68, 9 },
                    { 67, 67, 14 },
                    { 66, 66, 6 },
                    { 65, 65, 0 },
                    { 64, 64, 10 },
                    { 63, 63, 17 },
                    { 62, 62, 12 },
                    { 61, 61, 0 },
                    { 60, 60, 5 },
                    { 59, 59, 9 },
                    { 58, 58, 7 },
                    { 57, 57, 13 },
                    { 56, 56, 4 },
                    { 55, 55, 9 },
                    { 54, 54, 14 },
                    { 53, 53, 8 },
                    { 74, 74, 1 },
                    { 52, 52, 13 },
                    { 75, 75, 7 },
                    { 77, 77, 18 },
                    { 98, 98, 7 },
                    { 97, 97, 8 },
                    { 96, 96, 7 },
                    { 95, 95, 17 },
                    { 94, 94, 5 },
                    { 93, 93, 8 },
                    { 92, 92, 14 },
                    { 91, 91, 9 },
                    { 90, 90, 1 },
                    { 89, 89, 13 },
                    { 88, 88, 9 },
                    { 87, 87, 0 },
                    { 86, 86, 17 },
                    { 85, 85, 4 },
                    { 84, 84, 13 },
                    { 83, 83, 15 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 14 },
                    { 81, 81, 15 },
                    { 80, 80, 6 },
                    { 79, 79, 11 },
                    { 78, 78, 4 },
                    { 76, 76, 17 },
                    { 51, 51, 19 },
                    { 50, 50, 6 },
                    { 49, 49, 6 },
                    { 22, 22, 15 },
                    { 21, 21, 2 },
                    { 20, 20, 7 },
                    { 19, 19, 19 },
                    { 18, 18, 6 },
                    { 17, 17, 12 },
                    { 16, 16, 5 },
                    { 15, 15, 8 },
                    { 14, 14, 19 },
                    { 13, 13, 11 },
                    { 12, 12, 18 },
                    { 11, 11, 15 },
                    { 10, 10, 12 },
                    { 9, 9, 14 },
                    { 8, 8, 17 },
                    { 7, 7, 14 },
                    { 6, 6, 8 },
                    { 5, 5, 7 },
                    { 4, 4, 18 },
                    { 3, 3, 9 },
                    { 2, 2, 8 },
                    { 23, 23, 15 },
                    { 24, 24, 2 },
                    { 25, 25, 9 },
                    { 26, 26, 1 },
                    { 48, 48, 13 },
                    { 47, 47, 6 },
                    { 46, 46, 2 },
                    { 45, 45, 10 },
                    { 44, 44, 10 },
                    { 43, 43, 17 },
                    { 42, 42, 5 },
                    { 41, 41, 19 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 17 },
                    { 39, 39, 11 },
                    { 99, 99, 9 },
                    { 38, 38, 17 },
                    { 36, 36, 2 },
                    { 35, 35, 5 },
                    { 34, 34, 2 },
                    { 33, 33, 4 },
                    { 32, 32, 8 },
                    { 31, 31, 11 },
                    { 30, 30, 4 },
                    { 29, 29, 0 },
                    { 28, 28, 1 },
                    { 27, 27, 7 },
                    { 37, 37, 2 },
                    { 100, 100, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
