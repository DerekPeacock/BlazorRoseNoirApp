using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorRoseNoirApp.Server.Data.Migrations
{
    public partial class AddProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainImageUrl = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngredientList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergenList = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Variations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomingStock = table.Column<int>(type: "int", nullable: false),
                    AvailableStock = table.Column<int>(type: "int", nullable: false),
                    ComittedStock = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    SizeUnit = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    WeightUnit = table.Column<int>(type: "int", nullable: false),
                    VariationType = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Variations_ProductId",
                table: "Variations",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
