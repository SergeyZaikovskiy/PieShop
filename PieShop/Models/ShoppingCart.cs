using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext appDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems{ get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider service) 
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId,
            };
        }

        public void AddToCart(Pie pie, int amount)
        {
            var shoppingCartItem = appDbContext
                                    .ShoppingCartItems
                                    .SingleOrDefault(s => s.Pie.Id == pie.Id && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null) 
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Pie = pie,
                    Amount = 1,
                };

                appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Pie pie)
        {
            var shoppingCartItem = appDbContext
                                    .ShoppingCartItems
                                    .SingleOrDefault(s => s.Pie.Id == pie.Id && s.ShoppingCartId == ShoppingCartId);

            var amount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    amount = shoppingCartItem.Amount;
                }
                else 
                {
                    appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }          

            appDbContext.SaveChanges();

            return amount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                    (ShoppingCartItems = appDbContext
                        .ShoppingCartItems
                        .Where(c => c.ShoppingCartId == ShoppingCartId)
                        .Include(s => s.Pie)
                        .ToList());
        }

        public void ClearCart()
        {
            var cartItems = appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal() 
        {
            var total = appDbContext
                        .ShoppingCartItems
                        .Where(s => s.ShoppingCartId == ShoppingCartId)
                        .Select(c => c.Pie.Price * c.Amount)
                        .Sum();
            return total;
        }
    }
}
