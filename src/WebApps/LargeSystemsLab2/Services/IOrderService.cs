using LargeSystemsLab2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LargeSystemsLab2.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
