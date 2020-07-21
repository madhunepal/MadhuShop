using Microsoft.EntityFrameworkCore.Migrations;

namespace MadhuShop.Migrations
{
    public partial class addedcolums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Catogory",
                table: "Catogory");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Catogory");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Catogory");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Catogory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescription",
                table: "Catogory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Catogory",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catogory",
                table: "Catogory",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    ClothId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ImageThumbNailUrl = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsOnSale = table.Column<bool>(nullable: false),
                    IsOnStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.ClothId);
                    table.ForeignKey(
                        name: "FK_Clothes_Catogory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catogory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_CategoryId",
                table: "Clothes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catogory",
                table: "Catogory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Catogory");

            migrationBuilder.DropColumn(
                name: "CategoryDescription",
                table: "Catogory");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Catogory");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Catogory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Catogory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catogory",
                table: "Catogory",
                column: "Id");
        }
    }
}
