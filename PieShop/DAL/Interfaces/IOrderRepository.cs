using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.DAL.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
