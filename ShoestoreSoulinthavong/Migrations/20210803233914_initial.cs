using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoestoreSoulinthavong.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    ShoeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    RetailPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.ShoeId);
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "Brand", "Color", "Gender", "RetailPrice", "Size", "Style" },
                values: new object[,]
                {
                    { 1, "Adidas", "Black", "Men", 180.0, 9.5, "Sneaker" },
                    { 2, "Nike", "Grey", "Women", 90.0, 6.5, "Sneaker" },
                    { 3, "Converse", "White", "Unisex", 44.990000000000002, 8.0, "Sneaker" },
                    { 4, "Birkenstocks", "Nude", "Unisex", 99.950000000000003, 9.0, "Sandal" },
                    { 5, "Teva", "Black", "Unisex", 49.950000000000003, 5.0, "Sandal" },
                    { 6, "Timberland", "Yellow", "Men", 165.99000000000001, 8.0, "Boot" },
                    { 7, "Uggs", "Chestnut", "Women", 205.99000000000001, 5.0, "Boot" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoes");
        }
    }
}
