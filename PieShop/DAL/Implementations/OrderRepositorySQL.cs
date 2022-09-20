using PieShop.DAL.Interfaces;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.DAL.Implementations
{
    public class OrderRepositorySQL : IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly ShoppingCart shoppingCart;

        public OrderRepositorySQL(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            this.appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;

            appDbContext.Oreders.Add(order);

            var shoppingCartItems = shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems) 
            {
                var orderDetails = new OrderDetails
                {
                    Amount = item.Amount,
                    PieId = item.Pie.Id,
                    OrderId = order.OrderId,
                    Price = item.Pie.Price
                };

                appDbContext.OrderDetails.Add(orderDetails);
            }

            appDbContext.SaveChanges();
        }
    }
}
