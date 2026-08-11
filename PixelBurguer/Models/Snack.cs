namespace PixelBurguer.Models
{
    public class Snack
    {
        public int SnackId { get; set; }

        public string SnackName { get; set; }

        public string SnackDescriptionShort { get; set; }

        public string SnackDescriptionLong { get; set; }

        public decimal SnackPrice { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsSnackFavorite { get; set; }

        public bool IsSnackAvailable { get; set; }


        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        }
}
