using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixelBurguer.Models
{
    [Table("Snaks")]
    public class Snack
    {
        
        public int SnackId { get; set; }

        [Required(ErrorMessage = "The SnackName field is required.")]
        [Display(Name = "Snack Name")]
        [StringLength(80,MinimumLength = 10, ErrorMessage = "The SnackName must be between {1} and {0} characters.")]
        public string SnackName { get; set; }

        [Required(ErrorMessage = "The SnackDescriptionShort field is required.")]
        [Display(Name = "Description")]
        [MinLength(20, ErrorMessage = "The SnackDescriptionShort must be at least {1} characters long.")]
        [MaxLength(200, ErrorMessage = "The SnackDescriptionShort cannot exceed {1} characters.")]
        public string SnackDescriptionShort { get; set; }

        [Required(ErrorMessage = "The SnackDescriptionLong field is required.")]
        [Display(Name = "Description")]
        [MinLength(20, ErrorMessage = "The SnackDescriptionLong must be at least {1} characters long.")]
        [MaxLength(200, ErrorMessage = "The SnackDescriptionLong cannot exceed {1} characters.")]
        public string SnackDescriptionLong { get; set; }

        [Required(ErrorMessage = "The SnackPrice field is required.")]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "The SnackPrice must be between {1} and {2}.")]
        public decimal SnackPrice { get; set; }

        [Display(Name = "Image URL")]
        [StringLength(200, ErrorMessage = "The ImageUrl cannot exceed {1} characters.")]
        public string ImageUrl { get; set; }

        [Display(Name = "Image Thumbnail URL")]
        [StringLength(200, ErrorMessage = "The ImageThumbnailUrl cannot exceed {1} characters.")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Is Favorite?")]
        public bool IsSnackFavorite { get; set; }

        [Display(Name = "Is Available?")]
        public bool IsSnackAvailable { get; set; }


        //create a foreign key for the Category table
        public int CategoryId { get; set; }

        //create a navigation property for the Category table
        public virtual Category Category { get; set; }
        }
}
