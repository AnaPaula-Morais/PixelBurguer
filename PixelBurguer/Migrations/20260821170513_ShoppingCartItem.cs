using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelBurguer.Migrations
{
    /// <inheritdoc />
    public partial class ShoppingCartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartIntems",
                columns: table => new
                {
                    ShoppingCartItemtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SnackId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartIntems", x => x.ShoppingCartItemtId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartIntems_Snacks_SnackId",
                        column: x => x.SnackId,
                        principalTable: "Snacks",
                        principalColumn: "SnackId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartIntems_SnackId",
                table: "ShoppingCartIntems",
                column: "SnackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartIntems");
        }
    }
}
