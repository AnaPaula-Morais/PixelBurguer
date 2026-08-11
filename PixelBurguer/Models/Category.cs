namespace PixelBurguer.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Snack> Snacks { get; set; }
    }
}
