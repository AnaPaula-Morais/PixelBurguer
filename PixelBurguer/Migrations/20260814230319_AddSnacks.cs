using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelBurguer.Migrations
{
    /// <inheritdoc />
    public partial class AddSnacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId,SnackDescriptionShort,SnackDescriptionLong,IsSnackAvailable,ImageThumbnailUrl,ImageUrl,IsSnackFavorite,SnackName,SnackPrice) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, '/images/cheeseSalada.png','/images/cheeseSalada.png', 0 ,'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId,SnackDescriptionShort,SnackDescriptionLong,IsSnackAvailable,ImageThumbnailUrl,ImageUrl,IsSnackFavorite,SnackName,SnackPrice) VALUES(1,'Pão, presunto, mussarela e tomate','Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.',1,'/images/mistoQuente.png','/images/mistoQuente.png',0,'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId,SnackDescriptionShort,SnackDescriptionLong,IsSnackAvailable,ImageThumbnailUrl,ImageUrl,IsSnackFavorite,SnackName,SnackPrice) VALUES(1,'Pão, hambúrger, presunto, mussarela e batalha palha','Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha.',1,'/images/cheeseburger.png','/images/cheeseburger.png',0,'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO Snacks(CategoryId,SnackDescriptionShort,SnackDescriptionLong,IsSnackAvailable,ImageThumbnailUrl,ImageUrl,IsSnackFavorite,SnackName,SnackPrice) VALUES(2,'Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte','Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.',1,'/images/lancheNatural.png','/images/lancheNatural.png',1,'Lanche Natural', 15.00)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Snacks");
        }
    }
}
