using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixelBurguer.Models
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }

        [StringLength(100, ErrorMessage = "The CategoryName cannot exceed 100 characters.")]
        [Required(ErrorMessage = "The CategoryName field is required.")]
        [Display(Name = "Name")]
        public string CategoryName { get; set; }

        [StringLength(200, ErrorMessage ="The CategoryDescription cannot exceed 200 characters.")]
        [Required(ErrorMessage = "The CategoryDescription field is required.")]
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }

        public List<Snack> Snacks { get; set; }
    }
}
