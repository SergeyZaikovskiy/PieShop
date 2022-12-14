using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

namespace PieShop.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
           var items = shoppingCart.GetShoppingCartItems();
           shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel 
            {
                ShoppingCart = shoppingCart,
                Total = shoppingCart.GetShoppingCartTotal(),
            };

            return View(shoppingCartViewModel);
        }
    }
}
