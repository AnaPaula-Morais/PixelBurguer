using PixelBurguer.Context;

namespace PixelBurguer.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _context;

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            //definition a session
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //get a service type our context
            var context = services.GetService<AppDbContext>();

            //get or create cart id
            string cartId = session.GetString("Cart")?? Guid.NewGuid().ToString();

            //set cart id in session
            session.SetString("cartId", cartId);

            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId,
            };
        }

        public void AddCart(Snack snack)
        {
            var shoppingCartItem = _context.ShoppingCartIntems.SingleOrDefault(
                s => s.Snack.SnackId == snack.SnackId &&
                s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Snack = snack,
                    Quantity = 1
                };

                _context.ShoppingCartIntems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }

            _context.SaveChanges();
        }

        public void RemoveCart(Snack snack)
        {
            var shoppingCartItem = _context.ShoppingCartIntems.SingleOrDefault(
                s => s.Snack.SnackId == snack.SnackId &&
                s.ShoppingCartId == ShoppingCartId);

            //var quantityLocal = 0;
            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    //quantityLocal = shoppingCartItem.Quantity;
                }
                else
                {
                    _context.ShoppingCartIntems.Remove(shoppingCartItem);
                }
            }
            _context.SaveChanges();
            //return quantityLocal;
        }
    }
}
