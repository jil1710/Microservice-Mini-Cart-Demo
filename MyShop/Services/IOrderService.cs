using MyShop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyShop.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
