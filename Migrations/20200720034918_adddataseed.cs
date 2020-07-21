using Microsoft.EntityFrameworkCore.Migrations;

namespace MadhuShop.Migrations
{
    public partial class adddataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catogory",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "DisplayOrder" },
                values: new object[] { 1, "belly bottom pant for male", "Pant", 0 });

            migrationBuilder.InsertData(
                table: "Catogory",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "DisplayOrder" },
                values: new object[] { 2, "Cow Boy Hat", "Hat", 0 });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "ClothId", "CategoryId", "Description", "ImageThumbNailUrl", "ImageUrl", "IsOnSale", "IsOnStock", "Name", "Price" },
                values: new object[] { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.", "\\Images\\jeans", "\\images\\jeans", false, true, "Soft Jeans", 45.950000000000003 });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "ClothId", "CategoryId", "Description", "ImageThumbNailUrl", "ImageUrl", "IsOnSale", "IsOnStock", "Name", "Price" },
                values: new object[] { 2, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.", "\\Images\\hat", "\\images\\hat", false, true, "Cow boy hat", 45.950000000000003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClothId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClothId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catogory",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catogory",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
