using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelBurguer.Migrations
{
    /// <inheritdoc />
    public partial class AddCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, CategoryDescription) " +
                "VALUES('Normal','Snacks made with normal ingredients')");

            migrationBuilder.Sql("INSERT INTO Categories(CategoryName,CategoryDescription) " +
                "VALUES('Natural','Snacks made with whole and natural ingredients')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
