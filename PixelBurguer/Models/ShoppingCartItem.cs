using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixelBurguer.Models
{
    [Table("ShoppingCartIntems")]
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemtId { get; set; }

        public Snack Snack { get; set; }

        public int Quantity { get; set; }

        [StringLength(200)]
        public string ShoppingCartId { get; set; }
    }
}
