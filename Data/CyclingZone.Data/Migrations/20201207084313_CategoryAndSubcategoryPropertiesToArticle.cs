using Microsoft.EntityFrameworkCore.Migrations;

namespace CyclingZone.Data.Migrations
{
    public partial class CategoryAndSubcategoryPropertiesToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subcategory",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Subcategory",
                table: "Articles");
        }
    }
}
