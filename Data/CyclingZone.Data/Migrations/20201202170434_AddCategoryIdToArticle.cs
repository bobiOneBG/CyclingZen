namespace CyclingZone.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddCategoryIdToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Articles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
