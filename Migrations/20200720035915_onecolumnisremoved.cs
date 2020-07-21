using Microsoft.EntityFrameworkCore.Migrations;

namespace MadhuShop.Migrations
{
    public partial class onecolumnisremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Catogory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Catogory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
