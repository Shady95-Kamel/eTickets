using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IOrdersService
    {
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
    }
}
